extends PanelContainer

@onready var sender_label: Label = $MarginContainer/VBoxContainer/HBoxContainer/SenderLabel
@onready var details_label: Label = $MarginContainer/VBoxContainer/ScrollContainer/DetailsLabel
@onready var money_label: Label = $MarginContainer/VBoxContainer/HBoxContainer/MoneyLabel
@onready var scroll_container: ScrollContainer = $MarginContainer/VBoxContainer/ScrollContainer

var offer_selected: OfferBase
var offer_node: Node = self

signal offer_open
signal offer_hovered

func _ready() -> void:
	sender_label.text = offer_selected.sender
	details_label.text = offer_selected.intro
	if offer_selected.money_reward < 5:
		money_label.text = "${0}".format([offer_selected.money_reward])
	else:
		money_label.text = "${0}-{1}".format([offer_selected.money_reward, int(offer_selected.money_reward * 1.3)])
	
func _on_gui_input(event: InputEvent) -> void:
	if event is InputEventMouseButton and event.is_pressed() and event.button_index == MOUSE_BUTTON_LEFT:
		offer_open.emit(offer_selected, offer_node)

func _on_mouse_entered() -> void:
	offer_hovered.emit(offer_node)

func _on_mouse_exited() -> void:
	offer_hovered.emit(null)
