extends PanelContainer

@onready var price_label: Label = $MarginContainer/VBoxContainer/PriceLabel
@onready var animation_player: AnimationPlayer = $AnimationPlayer

signal item_details_hovered
signal item_details_entered
signal item_details_exited
signal auction_finished

func _on_details_label_gui_input(event: InputEvent) -> void:
	if event is InputEventMouseMotion:
		item_details_hovered.emit()

func _on_details_label_mouse_entered() -> void:
	item_details_entered.emit()

func _on_details_label_mouse_exited() -> void:
	item_details_exited.emit()
