extends PanelContainer

@onready var rich_text_label: RichTextLabel = $MarginContainer/HBoxContainer/VBoxContainerMessage/PanelContainer/MarginContainer/VBoxContainer/RichTextLabel
@onready var complete_button: Button = $MarginContainer/HBoxContainer/VBoxContainerMessage/PanelContainer/MarginContainer/VBoxContainer/CompleteButton
@onready var offer_node: PanelContainer = $MarginContainer/HBoxContainer/MarginContainer/ScrollContainer/VBoxContainer/OffersItemPanel

var current_hovered_offer: Node

func _ready() -> void:
	offer_node.connect("offer_hovered", _on_offer_hovered)
	offer_node.connect("offer_open", _on_offer_opened)

func _input(event: InputEvent) -> void:
	if event.is_action_pressed("right_interact"):
		if current_hovered_offer:
			# if the offer is selected
			if not TutorialGlobal.selected_offer:
				TutorialGlobal.selected_offer = true
				current_hovered_offer.add_theme_stylebox_override("panel", load(current_hovered_offer.get_theme_stylebox("panel").resource_path.replace("_unselected", "_selected")))
				if not TutorialGlobal.viewed_offer_selection_popup:
					TutorialGlobal.viewed_offer_selection_popup = true
					TutorialGlobal.spawn_popup("You've just selected an offer!\nOnce an offer is selected it can be completed and odds\n of it's requirement spawning will drastically increase.\nBeware though! By default you have a maximum of three offers\nyou can select and if you deselect an offer you'll be fined!\nPick carefully!")
			# if it isnt
			else:
				TutorialGlobal.selected_offer = false
				current_hovered_offer.add_theme_stylebox_override("panel", load(current_hovered_offer.get_theme_stylebox("panel").resource_path.replace("_selected", "_unselected")))
				if not TutorialGlobal.viewed_offer_deselection_popup:
					TutorialGlobal.viewed_offer_deselection_popup = true
					TutorialGlobal.spawn_popup("You've just deselected an offer!\nIn the real game you'd have been fined for this.\nYou'll need to reselect the offer in order\nto have the option to complete it.")
			_on_offer_opened()

func _on_offer_hovered(offer_node_hovered: Node) -> void:
	current_hovered_offer = offer_node_hovered

func _on_offer_opened() -> void:
	offer_node.add_theme_stylebox_override("panel", load("res://styles/offer_clicked_{0}.tres".format([find_attachment(offer_node)])))
	rich_text_label.text = "Hi, I'm Sheville. I'm like a... personal assistant to Mr Poseidon.\nHe's instructed me to make sure you know what you're doing so for a little test I'd like you to get me a salmon."
	if TutorialGlobal.selected_offer:
		complete_button.visible = true
	else:
		complete_button.visible = false
	update_complete_button_state()

func find_attachment(offer_chosen: Node) -> String:
	if offer_chosen.get_theme_stylebox("panel").resource_path.contains("unselected"):
		return "unselected"
	else:
		return "selected"

func update_complete_button_state() -> void:
	complete_button.disabled = not TutorialGlobal.has_fish

func _on_complete_button_pressed() -> void:
	TutorialGlobal.reset_values()
	get_tree().change_scene_to_file("res://pages/dialogue/scenes/intermission_sequence.tscn")
