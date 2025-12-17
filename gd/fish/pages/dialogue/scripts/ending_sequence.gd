extends Control

@onready var rich_text_label: RichTextLabel = $VBoxContainer/RichTextLabel
@onready var next_button: Button = $VBoxContainer/NextButton

var dialogue: Array = ["Huh? You actually did it? I uh mean... congratulations! I knew you could!", "Great job bud.", "Sure took your time though. {0} minutes? You could do better than that.".format([int(convert_game_time_to_minutes())])]
var current_dialogue_position: int = 0

func _ready() -> void:
	$AnimationPlayer.play("start_intro")

func _on_next_button_pressed() -> void:
	if not current_dialogue_position == dialogue.size() - 1:
		current_dialogue_position += 1
		rich_text_label.text = dialogue[current_dialogue_position]
		$AnimationPlayer.play("button_inactive")
		$ReadingTimer.start()
	else:
		$AnimationPlayer.play("end_intro")

func _on_reading_timer_timeout() -> void:
	if current_dialogue_position == dialogue.size() - 1:
		next_button.text = "i'll give it my best shot..."
	elif current_dialogue_position == 1:
		next_button.text = "thanks..."
	$AnimationPlayer.play("button_active")

func _on_animation_player_animation_finished(anim_name: StringName) -> void:
	if anim_name == "start_intro":
		$ReadingTimer.start()
		rich_text_label.text = dialogue[current_dialogue_position]
	elif anim_name == "end_intro":
		get_tree().change_scene_to_file("res://pages/main_menu/main_menu.tscn")

func convert_game_time_to_minutes() -> float:
	return float(int(Global.game_time) % 3600) / 60
