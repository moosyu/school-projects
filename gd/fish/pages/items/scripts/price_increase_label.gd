extends Label

@onready var spawn_label_animation_player: AnimationPlayer = $SpawnLabel

func _ready() -> void:
	$SpawnLabel.play("spawn")

func _on_spawn_label_animation_finished(anim_name: StringName) -> void:
	if anim_name == "spawn":
		queue_free()
