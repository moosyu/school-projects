extends Control

@onready var rich_text_label: RichTextLabel = $VBoxContainer/RichTextLabel
@onready var next_button: Button = $VBoxContainer/NextButton

var dialogue: Array = ["Hello? Yes, this is Aegae. Poseidon speaking.", "Hmm, yeah that's pretty rough champ. How about a deal?", "Well, as you know, I'm a pretty generous guy. How does a loan of 1000 bucks sound?", "A catch? Well... if you manage to reach the highest level in the field of fish trading, 5, I'll consider your debt paid.", "However, it'd be unfair to me if I don't get anything from this, so if you can't do it, I get you. How does that sound?"]
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
		next_button.text = "alright..."
	$AnimationPlayer.play("button_active")

func _on_animation_player_animation_finished(anim_name: StringName) -> void:
	if anim_name == "start_intro":
		$ReadingTimer.start()
		rich_text_label.text = dialogue[current_dialogue_position]
	elif anim_name == "end_intro":
		get_tree().change_scene_to_file("res://pages/tutorial/scenes/tutorial_menu.tscn")
