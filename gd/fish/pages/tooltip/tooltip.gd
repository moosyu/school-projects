extends PanelContainer

@onready var title_label: Label = $VBoxContainer/TitleLabel
@onready var details_label_1: Label = $VBoxContainer/DetailsLabel1
@onready var details_label_2: Label = $VBoxContainer/DetailsLabel2
@onready var details_label_3: Label = $VBoxContainer/DetailsLabel3
@onready var details_label_4: Label = $VBoxContainer/DetailsLabel4

func _on_item_hovered_details() -> void:
	# changing z index because i dunno i cant click through it even with filter ignore??
	z_index = 1
	# resetting y to that without the fact so there isnt a weird empty spot for every tooltip without a fact.
	# because this is a panelcontainer, if the fact is bigger than this it will expand to the height required
	size = Vector2(1, 1)
	position = get_global_mouse_position() + Vector2(15, -size.y + 15)

func _on_entered_details(hovered_details: Dictionary) -> void:
	$AnimationPlayer.play("tooltip_fade_in")
	title_label.text = hovered_details.fish_resource.species
	details_label_1.text = hovered_details.fish_resource.fact
	if hovered_details.fish_resource.always_spawnable:
		change_stats_labels_visibility(true)
		details_label_2.text = "Size: {0} {1}{2}".format([hovered_details.size_value, hovered_details.fish_resource.weight_measurement_longhand, plural_suffix(hovered_details.size_value)])
		details_label_3.text = "Expires in: {0} day{1}".format([hovered_details.expiration_date, plural_suffix(hovered_details.expiration_date)])
		details_label_4.text = hovered_details.alive_title
	else:
		change_stats_labels_visibility(false)

func _on_exited_details() -> void:
	$AnimationPlayer.play("tooltip_fade_out")

func change_stats_labels_visibility(true_or_false: bool):
	details_label_2.visible = true_or_false
	details_label_3.visible = true_or_false
	details_label_4.visible = true_or_false
	
func plural_suffix(value: int) -> String:
	return "" if value == 1 else "s"
