extends PanelContainer

func _on_item_hovered_details() -> void:
	z_index = 1
	size = Vector2(1, 1)
	position = get_global_mouse_position() + Vector2(15, -size.y + 15)

func _on_entered_details() -> void:
	$AnimationPlayer.play("tooltip_fade_in")

func _on_exited_details() -> void:
	$AnimationPlayer.play("tooltip_fade_out")
