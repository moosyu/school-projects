extends Node

const POPUP_LABEL = preload("res://pages/items/scenes/popup_label.tscn")
const AI_WINNING = preload("res://styles/ai_winning.tres")
const AI_UNCHANGED = preload("res://styles/ai_unchanged.tres")
const AI_LOSING = preload("res://styles/ai_losing.tres")

@onready var ai_container: VBoxContainer = $"../AIContainer"
@onready var fish_display: Control = $".."

var ais: Array[PanelContainer]
var choosable_ais: Array[PanelContainer]
var chosen_ai: PanelContainer
var top_ai: PanelContainer
var bid_history: Array[Node]
var fail_bid_message: Array[String] = ["damn", "nope", "not a chance", "yikes", "..."]

signal ai_turn_made

func _ready() -> void:
	for child in ai_container.get_children():
		ais.append(child)

func take_ai_turn() -> void:
	var fish_instance: PanelContainer = get_parent().fish_instance
	refill_ai_array()
	chosen_ai = choosable_ais.pick_random()
	$AITurnTimer.start(chosen_ai.turn_time)
	chosen_ai.calculate_confidence(bid_history, fish_instance)
	# confidence calculations not specific to any ai
	if fish_instance.fish_resource == chosen_ai.fish_of_interest:
		chosen_ai.confidence += 15
	if chosen_ai.money < fish_instance.current_price or not bid_history.is_empty() and bid_history.back() == chosen_ai:
		chosen_ai.confidence = 0
	#if chosen_ai.money > fish_instance.current_price:
		#chosen_ai.confidence += int((chosen_ai.money / fish_instance.current_price) * 10)
	#else:
		#chosen_ai.confidence = 0
	#print(chosen_ai.confidence)
	#print(chosen_ai.participant_name)
	chosen_ai.confidence = clampi(chosen_ai.confidence, 0, 100)
	
func _on_round_started() -> void:
	take_ai_turn()

func _on_ai_turn_timer_timeout() -> void:
	if chosen_ai.confidence >= 20 and randi_range(chosen_ai.confidence, 100) > 75:
		if not bid_history.is_empty() and bid_history.back().participant_name == Global.player_name:
			Global.set_notification("You've been outbid!", Global.DEFAULT_LABEL_BAD)
		ai_turn_made.emit()
		bid_history.append(chosen_ai)
		if top_ai:
			top_ai.profile_container.add_theme_stylebox_override("panel", AI_LOSING)
		chosen_ai.profile_container.add_theme_stylebox_override("panel", AI_WINNING)
		top_ai = chosen_ai
	else:
		var popup_label_instance: Label = POPUP_LABEL.instantiate()
		# have to make sure its added as a child of fish_display or else if im in a different scene itll just appear there
		fish_display.add_child(popup_label_instance)
		popup_label_instance.add_theme_color_override("font_color", Color("#ff1c2e"))
		popup_label_instance.text = fail_bid_message.pick_random()
		popup_label_instance.position = Vector2(chosen_ai.global_position.x + chosen_ai.size.x / 2 - popup_label_instance.size.x / 2, chosen_ai.global_position.y + chosen_ai.size.y / 2)
		popup_label_instance.rotation = deg_to_rad(randi_range(-15, 15))
	choosable_ais.erase(chosen_ai)
	take_ai_turn()

func _on_round_ended() -> void:
	$AITurnTimer.stop()
	top_ai = null
	if not bid_history.is_empty():
		for participant in bid_history:
			if participant is PanelContainer:
				participant.profile_container.add_theme_stylebox_override("panel", AI_UNCHANGED)
	bid_history.clear()

func refill_ai_array() -> void:
	if choosable_ais.is_empty():
		# so when im erasing things from choosable ais it doesnt also get taken out of ais
		choosable_ais = ais.duplicate()
		choosable_ais.shuffle()
