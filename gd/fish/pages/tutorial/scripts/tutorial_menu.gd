extends Control

const TUTORIAL_OFFERS_LIST = preload("res://pages/tutorial/scenes/tutorial_offers_list.tscn")
const POPUP = preload("res://pages/popup/popup.tscn")
const TUTORIAL_STORAGE_CONTAINER = preload("res://pages/tutorial/scenes/tutorial_storage_container.tscn")
const TUTORIAL_CATALOG = preload("res://pages/tutorial/scenes/tutorial_catalog.tscn")
const TUTORIAL_FISH_DISPLAY = preload("res://pages/tutorial/scenes/tutorial_fish_display.tscn")

@onready var start_button: Button = $VBoxContainer/NavbarBottomContainer/MarginContainer/ButtonsContainer/StartButton
@onready var main_content_panel: Panel = $VBoxContainer/MainContentPanel
@onready var catalog_button: Button = $VBoxContainer/NavbarBottomContainer/MarginContainer/ButtonsContainer/CatalogButton
@onready var browse_button: Button = $VBoxContainer/NavbarBottomContainer/MarginContainer/ButtonsContainer/BrowseButton

func _ready() -> void:
	TutorialGlobal.connect("popup_spawn", _on_popup_spawned)

func _on_offers_button_pressed() -> void:
	if not main_content_panel.has_node("TutorialOffersContainer"):
		var offer_list_instance = TUTORIAL_OFFERS_LIST.instantiate()
		main_content_panel.add_child(offer_list_instance)
	show_only("TutorialOffersContainer")
	main_content_panel.get_node("TutorialOffersContainer").update_complete_button_state()
	if not TutorialGlobal.viewed_offer_popup:
		TutorialGlobal.viewed_offer_popup = true
		TutorialGlobal.spawn_popup("You just opened your offers!\nIn the real game this will be filled with a variety\nof offers for you to do but for now you only have one.\nRight click the offer to select it.")

func _on_storage_button_pressed() -> void:
	reload_scene("TutorialStorageContainer", TUTORIAL_STORAGE_CONTAINER)
	if not TutorialGlobal.viewed_storage_popup:
		TutorialGlobal.viewed_storage_popup = true
		TutorialGlobal.spawn_popup("Welcome to your storage!\nIn this screen you can view any items you've bought.\nYou may also sell the items but be warned,\nevery day that passes decreases the expiration date.\nIf that date reaches 0 your item expires and loses its value.")

func show_only(name_to_show: String) -> void:
	for child in main_content_panel.get_children():
		child.visible = (child.name == name_to_show)

func _on_popup_spawned(text: String) -> void:
	var popup_instance = POPUP.instantiate()
	popup_instance.popup_text = text
	add_child(popup_instance)

func reload_scene(scene_name: String, scene_instance) -> void:
	hide_scenes_children(main_content_panel)
	if main_content_panel.has_node(scene_name):
		main_content_panel.get_node(scene_name).queue_free()
	var instance: Node = scene_instance.instantiate()
	main_content_panel.add_child(instance)

func hide_scenes_children(scene: Node) -> void:
	for child in scene.get_children():
		child.visible = false

func _on_start_button_pressed() -> void:
	var auction_instance = TUTORIAL_FISH_DISPLAY.instantiate()
	main_content_panel.add_child(auction_instance)
	catalog_button.disabled = false
	browse_button.disabled = false
	show_only("TutorialFishDisplay")
	if not TutorialGlobal.viewed_auction_popup:
		TutorialGlobal.viewed_auction_popup = true
		TutorialGlobal.spawn_popup("Welcome to the auction menu!\nIn regular gameplay there will be 10 auctions with a fiv2e second timer each.\nYou'll have to compete against AI and buy the best value fish.")
	start_button.queue_free()

func _on_catalog_button_pressed() -> void:
	if not main_content_panel.has_node("CatalogContainer"):
		var catalog_instance = TUTORIAL_CATALOG.instantiate()
		main_content_panel.add_child(catalog_instance)
	show_only("TutorialCatalogContainer")
	if not TutorialGlobal.viewed_catalog_popup:
		TutorialGlobal.viewed_catalog_popup = true
		TutorialGlobal.spawn_popup("Welcome to the catalog!\nFor the tutorial this menu will be pretty uselss\nbut in game you can use this screen to estimate the\nprices of future fish based on the colour of\nstar they have.\nYou can even get an upgrade to view all future fish!")

func _on_browse_button_pressed() -> void:
	show_only("TutorialFishDisplay")
