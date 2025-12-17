extends PanelContainer

const AI_WINNING = preload("res://styles/ai_winning.tres")
const ITEM_PLAYER_LOSING = preload("res://styles/item_player_losing.tres")
const CLOWNFISH = preload("res://resources/fish/clownfish.tres")

@onready var profile_container: PanelContainer = $HBoxContainer/ProfileContainer
@onready var texture_rect: TextureRect = $HBoxContainer/ProfileContainer/TextureRect

var participant_name: String = "Steve"
var money: int
var spited_opponents: Array
var fish_of_interest: ItemBase = CLOWNFISH
var turn_time: float = 2.5
var confidence: int = 50

signal update_prices
signal end_turn
signal price_increased

func calculate_confidence(bid_history: Array[Node], _fish_instance: PanelContainer) -> void:
	if spited_opponents.size() > 1:
		spited_opponents.remove_at(0)
	if not bid_history.is_empty() and bid_history.has(self) and bid_history.back() != self:
		# finds the person who bid just after the ai (overbid them)
		spited_opponents.append(bid_history[bid_history.rfind(self) + 1])
		if spited_opponents.has(bid_history.back()):
			confidence += 30
		else:
			confidence += 20
	if Global.chocolate_bought and not bid_history.is_empty() and bid_history.back().participant_name == Global.player_name:
		confidence -= 25
	
