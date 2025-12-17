extends Control

func _on_play_button_pressed() -> void:
	$AnimationPlayer.play("play_transition")
	

func _on_tutorial_button_pressed() -> void:
	get_tree().change_scene_to_file("res://pages/dialogue/scenes/intro_sequence.tscn")

func _on_quit_button_pressed() -> void:
	get_tree().quit()

func _on_animation_player_animation_finished(anim_name: StringName) -> void:
	if anim_name == "play_transition":
		get_tree().change_scene_to_file("res://pages/menu/menu.tscn")
