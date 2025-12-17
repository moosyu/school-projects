extends Control

@onready var alert_label: Label = $ColorRect/VBoxContainer/PopupContainer/VBoxContainer/AlertLabel
@onready var details: Label = $ColorRect/VBoxContainer/PopupContainer/VBoxContainer/Details
@onready var v_box_container: VBoxContainer = $ColorRect/VBoxContainer

var game_start_popup: bool = false
var popup_text: String

signal popup_closed

func _ready() -> void:
	$AlertDetailsAnimationPlayer.play("alert_details_appear")
	$BackdropAnimationPLayer.play("backdrop_appear")
	details.text = popup_text
	v_box_container.pivot_offset = v_box_container.size / 2

func _on_finish_button_pressed() -> void:
	$BackdropAnimationPLayer.play("backdrop_disappear")
	$AlertDetailsAnimationPlayer.play("alert_details_disappear")
	if game_start_popup:
		popup_closed.emit()
	queue_free()

func _on_alert_animation_finished(anim_name: StringName) -> void:
	if anim_name == "alert_details_disappear":
		popup_closed.emit()
		queue_free()
