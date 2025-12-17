extends Control

@onready var rich_text_label: RichTextLabel = $VBoxContainer/RichTextLabel
@onready var next_button: Button = $VBoxContainer/NextButton

var dialogue: Array = ["Yikes, that was a real shame. I was rooting for you.", "Don't worry about paying back your debt though, everything given can be taken back by a guy like me.", "Piece by piece."]
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
		next_button.text = "..."
	$AnimationPlayer.play("button_active")

func _on_animation_player_animation_finished(anim_name: StringName) -> void:
	if anim_name == "start_intro":
		$ReadingTimer.start()
		rich_text_label.text = dialogue[current_dialogue_position]
	elif anim_name == "end_intro":
		get_tree().change_scene_to_file("res://pages/main_menu/main_menu.tscn")
