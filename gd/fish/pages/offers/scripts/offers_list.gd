extends PanelContainer

const OFFER: PackedScene = preload("res://pages/offers/scenes/offer.tscn")

@onready var offers_container: VBoxContainer = $MarginContainer/HBoxContainer/MarginContainer/ScrollContainer/VBoxContainer
@onready var rich_text_label: RichTextLabel = $MarginContainer/HBoxContainer/VBoxContainerMessage/PanelContainer/MarginContainer/VBoxContainer/RichTextLabel
@onready var offers_list: VBoxContainer = $MarginContainer/HBoxContainer/MarginContainer/ScrollContainer/VBoxContainer
@onready var complete_button: Button = $MarginContainer/HBoxContainer/VBoxContainerMessage/PanelContainer/MarginContainer/VBoxContainer/CompleteButton

var current_offer_node: Node
var current_offer_resource: OfferBase
var current_hovered_offer: Node
var initial_load: bool = false

func _ready() -> void:
	Global.connect("update_complete_button", _on_update_complete_button)

func _input(event: InputEvent) -> void:
	# sorry for the classic if circle idk how to do this better :(
	if event.is_action_pressed("right_interact"):
		if current_hovered_offer:
			if not Global.selected_offers.has(current_hovered_offer) and Global.selected_offers.size() < Global.max_offers_selectable:
				Global.selected_offers.append(current_hovered_offer)
				current_hovered_offer.add_theme_stylebox_override("panel", load(current_hovered_offer.get_theme_stylebox("panel").resource_path.replace("_unselected", "_selected")))
			else:
				Global.selected_offers.erase(current_hovered_offer)
				current_hovered_offer.add_theme_stylebox_override("panel", load(current_hovered_offer.get_theme_stylebox("panel").resource_path.replace("_selected", "_unselected")))
				Global.update_money(Global.money - 100 * (Global.player_level + 1))
			Global.update_selected_size()
			_on_offer_opened(current_hovered_offer.offer_selected, current_hovered_offer)

func _on_update_complete_button():
	# offer_completable_with() returns {} if an offer doesnt have a fish it can use to complete
	if offer_completable_with().is_empty():
		complete_button.disabled = true
	else:
		complete_button.disabled = false

func _on_offer_opened(offer_selected: OfferBase, offer_node: Node) -> void:
	if Global.selected_offers.has(offer_node):
		complete_button.visible = true
	else:
		if Global.selected_offers.size() >= Global.max_offers_selectable:
			return
		complete_button.visible = false
	rich_text_label.visible = true
	current_offer_resource = offer_selected
	current_offer_node = offer_node
	for offer in offers_list.get_children():
		offer.add_theme_stylebox_override("panel", load("res://styles/offer_unclicked_{0}.tres".format([find_attachment(offer)])))
	offer_node.add_theme_stylebox_override("panel", load("res://styles/offer_clicked_{0}.tres".format([find_attachment(offer_node)])))
	rich_text_label.text = (offer_selected.details
	.replace("MONEY_REWARD", str(offer_selected.money_reward))
	.replace("FISH_NAME", "[color=#42c46d]{0}[/color]".format([offer_selected.requirement.name.to_lower()]))
	.replace("REQUIRED_SIZE", "[color=#c44dbf]{0}[/color]".format([offer_selected.required_size]))
	.replace("REQUIRED_ALIVE", "[color=#42a5c4]alive[/color]")
	)
	complete_button_update()

func _on_offer_hovered(offer_node: Node) -> void:
	current_hovered_offer = offer_node

func close_offer() -> void:
	rich_text_label.visible = false
	complete_button.visible = false

func _on_complete_button_pressed() -> void:
	if offer_completable_with().size() > 0:
		Global.update_money(Global.money + randi_range(current_offer_resource.money_reward, int(current_offer_resource.money_reward * 1.3)))
		Global.increase_exp(current_offer_resource.exp_reward)
		Global.items_held.erase(offer_completable_with())
		Global.finished_offers.append(current_offer_resource)
		Global.selected_offers.erase(current_offer_node)
		Global.update_selected_size()
		close_offer()
		current_offer_node.queue_free()
		return

func complete_button_update() -> void:
	# will be true if not completable
	complete_button.disabled = not offer_completable_with().size() > 0

func offer_completable_with() -> Dictionary:
	var cheapest_fish: Dictionary
	for current_fish in Global.items_held:
		if Global.is_offer_completable_with_item(current_offer_resource, current_fish):
			if cheapest_fish.size() == 0 or cheapest_fish.price > current_fish.price:
				cheapest_fish = current_fish
	if cheapest_fish.size() > 0:
		return cheapest_fish
	return {}

func load_offer_list() -> void:
	for offer in get_missing_offers():
		var offer_instance = OFFER.instantiate()
		offer_instance.connect("offer_open", _on_offer_opened)
		offer_instance.connect("offer_hovered", _on_offer_hovered)
		offer_instance.offer_selected = offer
		offers_container.add_child(offer_instance)

func get_missing_offers() -> Array[OfferBase]:
	var currently_loaded_offers_temp: Array[Node] = offers_list.get_children()
	var missing: Array[OfferBase]
	for available_offer: OfferBase in Global.available_offers:
		if initial_load:
			if Global.finished_offers.has(available_offer):
				# continue moves to the next available offer item
				continue
			var found: bool = false
			for node in currently_loaded_offers_temp:
				if node.offer_selected == available_offer:
					currently_loaded_offers_temp.erase(node)
					found = true
					break
			if not found:
				missing.append(available_offer)
		else:
			missing.append(available_offer)
	initial_load = true
	return missing

func find_attachment(offer_chosen: Node) -> String:
	if offer_chosen.get_theme_stylebox("panel").resource_path.contains("unselected"):
		return "unselected"
	else:
		return "selected"
