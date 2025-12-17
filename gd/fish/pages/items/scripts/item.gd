extends PanelContainer

# declare consts and variables
const ITEM_PLAYER_WINNING = preload("res://styles/item_player_winning.tres")

# declare variables for nodes
@onready var icon_texture: TextureRect = $MarginContainer/VBoxContainer/IconTexture
@onready var details_label: Label = $MarginContainer/VBoxContainer/HBoxContainer/DetailsLabel
@onready var price_label: Label = $MarginContainer/VBoxContainer/PriceLabel
@onready var animation_player: AnimationPlayer = $AnimationPlayer
@onready var hidden_panel: PanelContainer = $HiddenPanel
@onready var star_texture: TextureRect = $MarginContainer/VBoxContainer/HBoxContainer/StarTexture

var fish_resource: ItemBase
var size_value: float
var expiration_value: float
var alive_value: bool
var current_price: int
var fish_details: Dictionary

signal item_details_hovered
signal item_details_entered
signal item_details_exited
signal auction_finished

func _on_details_label_gui_input(event: InputEvent) -> void:
	if event is InputEventMouseMotion:
		item_details_hovered.emit()

func _on_details_label_mouse_entered() -> void:
	item_details_entered.emit(fish_details)

func _on_details_label_mouse_exited() -> void:
	item_details_exited.emit()

func _on_animation_player_animation_finished(anim_name: StringName) -> void:
	if anim_name == "auction_close":
		auction_finished.emit()
