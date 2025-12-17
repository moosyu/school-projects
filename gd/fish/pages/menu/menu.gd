extends Control

const FISH_DISPLAY = preload("res://pages/items/scenes/fish_display.tscn")
const OFFERS_LIST = preload("res://pages/offers/scenes/offers_list.tscn")
const STORAGE_CONTAINER = preload("res://pages/storage/scenes/storage_container.tscn")
const CATALOG = preload("res://pages/catalog/scenes/catalog.tscn")
const UPGRADES_CONTAINER = preload("res://pages/upgrades/scenes/upgrades_container.tscn")
const POPUP = preload("res://pages/popup/popup.tscn")
const NOTIFICATION = preload("res://pages/notifications/notification.tscn")

@onready var main_content_panel: Panel = $VBoxContainer/MainContentPanel
@onready var navbar_top_container: PanelContainer = $VBoxContainer/NavbarTopContainer
@onready var day_label: Label = $VBoxContainer/NavbarTopContainer/MarginContainer/StatsContainer/DayLabel
@onready var balance_label: Label = $VBoxContainer/NavbarTopContainer/MarginContainer/StatsContainer/BalanceLabel
@onready var exp_label: Label = $VBoxContainer/NavbarTopContainer/MarginContainer/StatsContainer/ExpLabel
@onready var notification_label: Label = $VBoxContainer/NavbarTopContainer/MarginContainer/NotificationLabel
@onready var auction_label: Label = $VBoxContainer/NavbarTopContainer/MarginContainer/StatsContainer/AuctionLabel
@onready var start_button: Button = $VBoxContainer/NavbarBottomContainer/MarginContainer/ButtonsContainer/StartButton
@onready var upgrades_button: Button = $VBoxContainer/NavbarBottomContainer/MarginContainer/ButtonsContainer/UpgradesButton
@onready var browse_button: Button = $VBoxContainer/NavbarBottomContainer/MarginContainer/ButtonsContainer/BrowseButton
@onready var buttons_container: HBoxContainer = $VBoxContainer/NavbarBottomContainer/MarginContainer/ButtonsContainer
@onready var offers_selected: Label = $VBoxContainer/NavbarTopContainer/MarginContainer/StatsContainer/OffersSelected
@onready var catalog_button: Button = $VBoxContainer/NavbarBottomContainer/MarginContainer/ButtonsContainer/CatalogButton

var scenes: Array[Dictionary] = [{"function": _on_offers_button_pressed, "disabled": false}, {"function": _on_catalog_button_pressed, "disabled": false}, {"function": _on_storage_button_pressed, "disabled": false}, {"function": _on_browse_button_pressed, "disabled": true}, {"function": _on_upgrades_button_pressed, "disabled": true}]
var current_scene: int = -1
var day_to_be_ended: bool
var unlocked_queue: Array[String]
var experience_requirements: Array = [0, 150, 250, 350, 450, 550]
var round_initialized: bool = false

func _ready() -> void:
	Global.connect("notification_updated", _on_notification_updated)
	Global.connect("money_changed", _on_money_changed)
	Global.connect("selected_size_changed", _on_selected_size_changed)
	Global.connect("exp_changed", _on_exp_changed)
	Global.connect("money_change_queued", _on_money_change_queued)
	day_label.text = "Day: {0}".format([Global.day])
	load_resources()
	_on_money_changed()
	_on_exp_changed()
	day_to_be_ended = false

#func _input(event: InputEvent) -> void:
	#if event.is_action_pressed("left"):
		#update_button_disabled_state()
		#var scene_increment: int = 1
		#if current_scene <= 0:
			#current_scene = scenes.size() - 1
		#var chosen_scene: Dictionary = scenes[current_scene - scene_increment]
		#while chosen_scene.disabled and current_scene - scene_increment >= 0:
			#scene_increment -= 1
		#if not chosen_scene.disabled:
			#chosen_scene.function.call()
			#current_scene -= scene_increment
	#if event.is_action_pressed("right"):
		#update_button_disabled_state()
		#var scene_increment: int = 1
		#if current_scene < scenes.size() - 1:
			#current_scene = 0
		#var chosen_scene: Dictionary = scenes[current_scene + scene_increment]
		#while chosen_scene.disabled and current_scene + scene_increment < scenes.size() - 1:
			#scene_increment += 1
		#if not chosen_scene.disabled:
			#chosen_scene.function.call()
			#current_scene += scene_increment

func update_button_disabled_state() -> void:
	for button in buttons_container.get_children().size() - 1:
		if buttons_container.get_children()[button].disabled:
			scenes[button].disabled = true
		else:
			scenes[button].disabled = false

func _on_offers_button_pressed() -> void:
	Global.update_offer_button()
	if not main_content_panel.has_node("OffersContainer"):
		var offer_list_instance = OFFERS_LIST.instantiate()
		main_content_panel.add_child(offer_list_instance)
	show_only("OffersContainer")
	main_content_panel.get_node("OffersContainer").load_offer_list()

func _on_catalog_button_pressed() -> void:
	update_catalog()
	show_only("CatalogContainer")

func _on_storage_button_pressed() -> void:
	reload_scene("StorageContainer", STORAGE_CONTAINER)

func _on_browse_button_pressed() -> void:
	open_fish_display()

func _on_upgrades_button_pressed() -> void:
	reload_scene("UpgradesContainer", UPGRADES_CONTAINER)

func _on_start_button_pressed() -> void:
	Global.game_started = true
	if day_to_be_ended:
		# pressed when round is to be ended, therefore need to reset text
		end_round()
		start_button.text = "START ROUND"
		browse_button.disabled = true
		# flip from true to false vice versa
		day_to_be_ended = not day_to_be_ended
		Global.expenses += Global.day * 10
	else:
		var popup_window_instance: Control = POPUP.instantiate()
		# start round, popup here is not in fact the round ending unlock notification
		if Global.selected_offers.size() < 3:
			popup_window_instance.game_start_popup = false
			popup_window_instance.popup_text = ("You haven't selected enough offers!\nHead back to offers and pick some more!\n(Right click offers to select them.)")
		else:
			popup_window_instance.game_start_popup = true
			popup_window_instance.popup_text = "Your daily expenses are:\n${0}\nIf you have below\n${0} when this auction\nis ended, you lose!".format([Global.expenses])
		add_child(popup_window_instance)
		popup_window_instance.connect("popup_closed", _on_popup_closed)

func _on_popup_closed() -> void:
	if not round_initialized:
		initialize_round()
		round_initialized = true
	open_fish_display()
	main_content_panel.get_node("FishDisplay").start_round()
	browse_button.disabled = false
	catalog_button.disabled = false
	start_button.visible = false
	day_to_be_ended = not day_to_be_ended

func open_fish_display() -> void:
	if not main_content_panel.has_node("FishDisplay"):
		var fish_display_instance = FISH_DISPLAY.instantiate()
		main_content_panel.add_child(fish_display_instance)
		fish_display_instance.connect("update_auction_label", _on_update_auction_label)
		fish_display_instance.connect("displayed_fish_changed", _on_displayed_fish_changed)
		fish_display_instance.connect("round_started", _on_round_started)
		fish_display_instance.connect("end_auction", _on_auction_ended)
	main_content_panel.get_node("FishDisplay").update_steve_icon()
	show_only("FishDisplay")

func reload_scene(scene_name: String, scene_instance) -> void:
	hide_scenes_children(main_content_panel)
	if main_content_panel.has_node(scene_name):
		main_content_panel.get_node(scene_name).queue_free()
	var instance: Node = scene_instance.instantiate()
	main_content_panel.add_child(instance)

func initialize_round() -> void:
	var fish_generator: FishGenerator = FishGenerator.new()
	for offer: Node in Global.selected_offers:
		# if the fish isnt always spawnable (unique) and only 50% of the time
		if not offer.offer_selected.requirement.always_spawnable and randi() % 2 == 0:
			Global.unique_fish_queue.append(offer.offer_selected.requirement)
	for i: int in range(Global.ITEM_SPAWN_COUNT - Global.unique_fish_queue.size()):
		Global.fish_queue.append(fish_generator.generate())
	if not Global.unique_fish_queue.is_empty():
		for fish in Global.unique_fish_queue:
			Global.fish_queue.append({"fish_resource": fish, "unique": true, "price":fish.base_price})
		Global.unique_fish_queue.clear()

func load_resources() -> void:
	Global.available_fish = Global.load_eligible_fish()
	Global.available_offers = Global.load_eligible_offers()
	Global.available_upgrades = Global.upgrade_resources

func end_round() -> void:
	if Global.player_level < 5:
		if Global.money >= Global.expenses:
			for item in Global.items_held:
				if item.expiration_date > 1:
					item.expiration_date -= 1
				else:
					Global.items_held.erase(item)
					Global.set_notification("A {0} went bad!".format([item.fish_resource.name.to_lower()]), Global.DEFAULT_LABEL_BAD)
			Global.day += 1
			Global.update_money(Global.money - Global.expenses)
			day_label.text = "Day: {0}".format([Global.day])
			# 4 is browse (i think). should really fix this so it's more clear but i have a day left to work on this :(
			if current_scene == 4:
				current_scene = 1
			Global.queue_position = 0
			Global.fish_queue.clear()
			Global.unique_fish_queue.clear()
			_on_update_auction_label()
			create_notification_popups()
			reload_scene("StorageContainer", STORAGE_CONTAINER)
			catalog_button.disabled = true
			round_initialized = false
			if Global.player_level >= 2:
				upgrades_button.disabled = false
			load_resources()
		else:
			Global.reset_global()
			get_tree().change_scene_to_file("res://pages/dialogue/scenes/failed_sequence.tscn")
func create_notification_popups() -> void:
	if unlocked_queue.is_empty():
		return
	var notification_instance = NOTIFICATION.instantiate()
	add_child(notification_instance)
	notification_instance.info_label.text = "YOU UNLOCKED {0}!!".format([unlocked_queue[0]])
	notification_instance.connect("notification_finished", _on_notification_finished)

func _on_notification_finished() -> void:
	unlocked_queue.remove_at(0)
	if unlocked_queue.is_empty():
		return
	create_notification_popups()

func show_only(name_to_show: String) -> void:
	for child in main_content_panel.get_children():
		# (child.name == name_to_show) returns true if they are equal to each other. im somewhat of a genius??
		child.visible = (child.name == name_to_show)

func hide_scenes_children(scene: Node) -> void:
	for child in scene.get_children():
		child.visible = false

func update_catalog() -> void:
	if not main_content_panel.has_node("CatalogContainer"):
		var catalog_instance = CATALOG.instantiate()
		main_content_panel.add_child(catalog_instance)
		catalog_instance.visible = false
	main_content_panel.get_node("CatalogContainer").load_catalog()

func _on_money_changed() -> void:
	balance_label.text = "Balance: ${0}".format([Global.money])

func _on_selected_size_changed() -> void:
	offers_selected.text = "Offers picked: {0}/{1}".format([Global.selected_offers.size(), Global.max_offers_selectable])

func _on_exp_changed() -> void:
	if Global.player_level < 5 and Global.player_exp >= experience_requirements[Global.player_level + 1]:
		Global.player_level += 1
		Global.player_exp -= experience_requirements[Global.player_level]
		if Global.player_level == 2:
			unlocked_queue.append("upgrades".to_upper())
		for fish in Global.fish_resources:
			if fish.level_requirement == Global.player_level:
				unlocked_queue.append(fish.name.to_upper())
	if Global.player_level < 5:
		exp_label.text = "Progress to level {0}: {1}/{2}".format([Global.player_level + 1, Global.player_exp, experience_requirements[Global.player_level + 1]])
	else:
		get_tree().change_scene_to_file("res://pages/dialogue/scenes/ending_sequence.tscn")
		exp_label.text = ("Max level!")

func _on_displayed_fish_changed() -> void:
	update_catalog()

func _on_update_auction_label() -> void:
	auction_label.text = "Auction: {0}/10".format([Global.queue_position])

func _on_notification_updated(text: String, label_settings: LabelSettings) -> void:
	notification_label.text = text
	notification_label.label_settings = label_settings

func _on_round_started() -> void:
	pass

func _on_money_change_queued(new_total: int, label_settings: LabelSettings) -> void:
	balance_label.text = "Balance: ${0}".format([new_total])
	balance_label.label_settings = label_settings

func _on_auction_ended() -> void:
	start_button.text = "END ROUND"
	start_button.visible = true
