extends PanelContainer

signal storage_details_hovered
signal storage_details_entered
signal storage_details_exited

func _on_details_label_gui_input(event: InputEvent) -> void:
	if event is InputEventMouseMotion:
		storage_details_hovered.emit()

func _on_details_label_mouse_entered() -> void:
	storage_details_entered.emit()

func _on_details_label_mouse_exited() -> void:
	storage_details_exited.emit()

func _on_sell_button_pressed() -> void:
	TutorialGlobal.spawn_popup("Sorry, I can't let you do that.\nYou need this fish to finish your offer!")
