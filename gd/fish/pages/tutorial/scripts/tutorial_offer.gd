extends PanelContainer

signal offer_open
signal offer_hovered

func _on_gui_input(event: InputEvent) -> void:
	if event is InputEventMouseButton and event.is_pressed() and event.button_index == MOUSE_BUTTON_LEFT:
		offer_open.emit()

func _on_mouse_entered() -> void:
	offer_hovered.emit(self)

func _on_mouse_exited() -> void:
	offer_hovered.emit(null)
