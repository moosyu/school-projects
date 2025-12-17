extends PanelContainer

const AI_WINNING = preload("res://styles/ai_winning.tres")
const ITEM_PLAYER_LOSING = preload("res://styles/item_player_losing.tres")
const CLOWNFISH = preload("res://resources/fish/clownfish.tres")

@onready var profile_container: PanelContainer = $HBoxContainer/ProfileContainer
@onready var texture_rect: TextureRect = $HBoxContainer/ProfileContainer/TextureRect

var participant_name: String = "Larry"
var money: int
var fish_of_interest: ItemBase = CLOWNFISH
var turn_time: float = 3.0
var confidence: int = 40

signal update_prices
signal end_turn
signal price_increased

func calculate_confidence(bid_history: Array[Node], _fish_instance: PanelContainer) -> void:
	if not bid_history.is_empty():
		confidence = 60 - bid_history.size() * 10
