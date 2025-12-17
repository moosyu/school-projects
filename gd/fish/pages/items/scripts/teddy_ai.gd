extends PanelContainer

const AI_WINNING = preload("res://styles/ai_winning.tres")
const ITEM_PLAYER_LOSING = preload("res://styles/item_player_losing.tres")
const SALMON = preload("res://resources/fish/salmon.tres")

@onready var profile_container: PanelContainer = $HBoxContainer/ProfileContainer
@onready var texture_rect: TextureRect = $HBoxContainer/ProfileContainer/TextureRect

var participant_name: String = "Teddy"
var money: int
var fish_of_interest: ItemBase = SALMON
var turn_time: float = 3.0
var confidence: int = 55

signal update_prices
signal end_turn
signal price_increased

func calculate_confidence(_bid_history: Array[Node], _fish_instance: PanelContainer) -> void:
	confidence -= 60 - (Global.queue_position * 10)
