# retired

extends Node

const AI_LOSING = preload("res://styles/ai_losing.tres")
const AI_UNCHANGED = preload("res://styles/ai_unchanged.tres")
const AI_CHOOSING = preload("res://styles/ai_choosing.tres")
const AI_WINNING = preload("res://styles/ai_winning.tres")

@export var participants: Array[Node]

var current_participant: Node
var bid_history: Array
var current_round_bids: int

signal auction_over(bid_history: Array)
signal change_turn

func _ready():
	#participants.shuffle()
	pass

func start_turn() -> void:
	change_turn.emit()
	while Global.current_turn_count < participants.size() - 1 and participants[Global.current_turn_count].disabled_bidding:
		Global.current_turn_count += 1
	current_participant = participants[Global.current_turn_count]
	if current_participant is PanelContainer:
		# bid code for ai (all ais are actually panelcontainers) 
		current_participant.profile_container.add_theme_stylebox_override("panel", AI_CHOOSING)
		var latest_spited_participant: String
		var offer_fish: bool = false
		for offer in Global.offer_resources:
			if offer.requirement == get_parent().fish_instance.fish_resource:
				offer_fish = true
		if bid_history.has(current_participant.participant_name) and bid_history.back() != current_participant.name:
			# for this to occur it must mean the ai has been overbid
			var spited_participant_pos = bid_history.rfind(current_participant.participant_name) - 1
			latest_spited_participant = bid_history[spited_participant_pos]
		current_participant.take_turn(latest_spited_participant, bid_history, get_parent().fish_instance, offer_fish)
	else:
		# bid code for player
		Global.set_notification("It's your turn to bid!", Global.DEFAULT_LABEL)
		current_participant.take_turn()

func _on_turn_ended(bid: bool) -> void:
	if bid:
		current_round_bids += 1
		bid_history.append(current_participant.participant_name)
	for participant in participants:
		if participant is PanelContainer:
			if not bid_history.is_empty() and bid_history.has(participant.participant_name):
				if participant.participant_name == bid_history.back():
					participant.profile_container.add_theme_stylebox_override("panel", AI_WINNING)
				else:
					participant.profile_container.add_theme_stylebox_override("panel", AI_LOSING)
			else:
				participant.profile_container.add_theme_stylebox_override("panel", AI_UNCHANGED)
	if Global.current_turn_count == participants.size() - 1:
		Global.current_turn_count = 0
		change_turn.emit()
		if current_round_bids <= 1:
			auction_over.emit(bid_history)
			bid_history.clear()
			for participant in participants:
				participant.disable_bidding(false)
			for participant in participants:
				if participant is PanelContainer:
					participant.profile_container.add_theme_stylebox_override("panel", AI_UNCHANGED)
		else:
			# if the participant didnt bid in the first turn dont allow to third party
			for participant in participants:
				if bid_history.has(participant):
					participant.disable_bidding(false)
				else:
					participant.disable_bidding(true)
		current_round_bids = 0
		await get_tree().create_timer(0.8).timeout
	else:
		Global.current_turn_count += 1
	start_turn()

func _on_start_button_pressed() -> void:
	start_turn()
