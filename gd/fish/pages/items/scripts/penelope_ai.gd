extends PanelContainer

const AI_WINNING = preload("res://styles/ai_winning.tres")
const ITEM_PLAYER_LOSING = preload("res://styles/item_player_losing.tres")
const TUNA = preload("res://resources/fish/tuna.tres")

@onready var profile_container: PanelContainer = $HBoxContainer/ProfileContainer
@onready var texture_rect: TextureRect = $HBoxContainer/ProfileContainer/TextureRect

var participant_name: String = "Penelope"
var money: int
var fish_of_interest: ItemBase = TUNA
var turn_time: float = 2.5
var confidence: int = 60

signal update_prices
signal end_turn
signal price_increased

func calculate_confidence(_bid_history: Array[Node], _fish_instance: PanelContainer) -> void:
	confidence += randi_range(1, 40)
