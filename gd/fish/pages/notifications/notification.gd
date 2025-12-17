extends Control

@onready var info_label: Label = $InfoLabel

signal notification_finished

func _ready() -> void:
	$SpinAnimationPlayer.play("movement")
	$FadeAnimationPlayer.play("appear")
	$GPUParticles2D.emitting = true
	$AudioStreamPlayer2D.play()

func _on_finish_button_pressed() -> void:
	$FadeAnimationPlayer.play("disappear")

func _on_fade_animation_player_animation_finished(anim_name: StringName) -> void:
	if anim_name == "disappear":
		queue_free()
		notification_finished.emit()
	elif anim_name == "appear":
		$TitleScaleAnimationPlayer.play("movement_title")
