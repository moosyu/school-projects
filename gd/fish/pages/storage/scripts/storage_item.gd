extends PanelContainer

@onready var icon_texture: TextureRect = $MarginContainer/VBoxContainer/IconTexture
@onready var details_label: Label = $MarginContainer/VBoxContainer/DetailsLabel
@onready var sell_button: Button = $MarginContainer/VBoxContainer/SellButton

var fish_details: Dictionary

signal storage_details_hovered
signal storage_details_entered
signal storage_details_exited

func _ready() -> void:
	var fish_name: String = fish_details.fish_resource.name
	icon_texture.texture = fish_details.fish_resource.fish_icon
	sell_button.text = "Sell: ${0}".format([fish_details.price])
	details_label.text =  "{0} {1}KG-{2}D-{3}".format([fish_name, fish_details.size_value, fish_details.expiration_date, fish_details.alive_title.left(1)])

func _on_sell_button_pressed() -> void:
	Global.update_money(Global.money + fish_details.price)
	Global.items_held.erase(fish_details)
	Global.update_offer_button()
	queue_free()

func _on_details_label_gui_input(event: InputEvent) -> void:
	if event is InputEventMouseMotion:
		storage_details_hovered.emit()

func _on_details_label_mouse_entered() -> void:
	storage_details_entered.emit(fish_details)

func _on_details_label_mouse_exited() -> void:
	storage_details_exited.emit()
