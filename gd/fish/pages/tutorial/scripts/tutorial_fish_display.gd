extends Control

const ITEM_PLAYER_WINNING: StyleBoxFlat = preload("res://styles/item_player_winning.tres")
const ITEM_PLAYER_LOSING: StyleBoxFlat = preload("res://styles/item_player_losing.tres")
const ITEM_UNCHANGED: StyleBoxFlat = preload("res://styles/item_unchanged.tres")

@onready var tutorial_item_container: PanelContainer = $TutorialItemContainer
@onready var bid_30: Button = $Bid30
@onready var sold_animation_player: AnimationPlayer = $SoldLabel/AnimationPlayer

var first_round: bool = true

func _ready() -> void:
	tutorial_item_container.connect("item_details_hovered", Callable(get_tree().current_scene.get_node("TutorialTooltip"), "_on_item_hovered_details"))
	tutorial_item_container.connect("item_details_entered", Callable(get_tree().current_scene.get_node("TutorialTooltip"), "_on_entered_details"))
	tutorial_item_container.connect("item_details_exited", Callable(get_tree().current_scene.get_node("TutorialTooltip"), "_on_exited_details"))

func _process(_delta: float) -> void:
	$TimeLabel.text = "Time left: {0}s".format([ceili($AuctionTimer.time_left)])
 
func _on_auction_timer_timeout() -> void:
	TutorialGlobal.has_fish = true
	TutorialGlobal.spawn_popup("You did it!\nNow you can complete Sheville's offer!")
	$AnimationPlayer.play("time_disappear")
	tutorial_item_container.animation_player.play("auction_close")
	sold_animation_player.play("sold_label_appear")
	
func _on_bid_30_pressed() -> void:
	if first_round:
		tutorial_item_container.price_label.text = "$26"
		bid_30.disabled = true
		tutorial_item_container.add_theme_stylebox_override("panel", ITEM_PLAYER_WINNING)
		await get_tree().create_timer(1).timeout
		tutorial_item_container.price_label.text = "$33"
		bid_30.text = "Bid $42"
		bid_30.disabled = false
		first_round = false
		tutorial_item_container.add_theme_stylebox_override("panel", ITEM_PLAYER_LOSING)
		TutorialGlobal.spawn_popup("Uh oh, you've just been outbid!\nYou'll be competing against AIs in this game who will\nbe bidding against you in every round.\nYou can tell you've been outbid by the\nred outline of the fish.\nBid again!")
	else:
		tutorial_item_container.price_label.text = "$42"
		bid_30.disabled = true
		tutorial_item_container.add_theme_stylebox_override("panel", ITEM_PLAYER_WINNING)
		$AnimationPlayer.play("time_appear")
		$AuctionTimer.start()
