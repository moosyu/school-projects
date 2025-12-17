extends Control

const AUCTION_TIME: int = 5
const ITEM: PackedScene = preload("res://pages/items/scenes/item.tscn")
const ITEM_PLAYER_WINNING: StyleBoxFlat = preload("res://styles/item_player_winning.tres")
const ITEM_PLAYER_LOSING: StyleBoxFlat = preload("res://styles/item_player_losing.tres")
const ITEM_UNCHANGED: StyleBoxFlat = preload("res://styles/item_unchanged.tres")
const AI_ICON_1: CompressedTexture2D = preload("res://assets/sprites/icons/ai_icon_1.png")
const AI_ICON_1_BLUSH: CompressedTexture2D = preload("res://assets/sprites/icons/ai_icon_1_blush.png")
const POPUP_LABEL: PackedScene = preload("res://pages/items/scenes/popup_label.tscn")
const DEFAULT_LABEL_BAD: LabelSettings = preload("res://styles/default_label_bad.tres")
const DEFAULT_LABEL: LabelSettings = preload("res://styles/default_label.tres")
const DETAILS_LABEL = preload("res://styles/details_label.tres")
const DETAILS_LABEL_UNDERPRICED = preload("res://styles/details_label_underpriced.tres")

@onready var bid_30: Button = $Bid30
@onready var steve_ai: PanelContainer = $AIContainer/SteveAI
@onready var sold_label_animation_player: AnimationPlayer = $SoldLabel/AnimationPlayer

var fish_instance: PanelContainer = ITEM.instantiate()
var participant_name: String = Global.player_name
var fish_details: Dictionary
var disabled_bidding: bool

signal displayed_fish_changed
signal update_auction_label
signal round_started
signal end_round
signal end_auction
signal price_increased

func _process(_delta: float) -> void:
	if $AuctionTimer.is_stopped():
		return
	$TimeLabel.text = "Time left: {0}s".format([ceili($AuctionTimer.time_left)])

func start_round() -> void:
	load_current_fish()
	load_fish_details()
	round_started.emit()
	_on_update_prices()
	$TimeLabel.visible = true
	$Bid30.visible = true
	$AuctionTimer.start(AUCTION_TIME)
	$AnimationPlayer.play("time_appear")
	fish_instance.visible = true
	# so auction number updates to 1
	update_auction_label.emit()

func load_current_fish() -> void:
	if not $FishContainer.has_node("ItemContainer"):
		$FishContainer.add_child(fish_instance)
		fish_instance.connect("item_details_hovered", Callable(get_tree().current_scene.get_node("Tooltip"), "_on_item_hovered_details"))
		fish_instance.connect("item_details_entered", Callable(get_tree().current_scene.get_node("Tooltip"), "_on_entered_details"))
		fish_instance.connect("item_details_exited", Callable(get_tree().current_scene.get_node("Tooltip"), "_on_exited_details"))
		fish_instance.connect("auction_finished", _on_auction_animation_finished)
		reset_ai_money()

func load_fish_details() -> void:
	if Global.queue_position < Global.fish_queue.size():
		fish_details = Global.fish_queue[Global.queue_position]
		var fish_resource_current: ItemBase = fish_details.fish_resource
		fish_instance.fish_details = fish_details
		# so fish can be sold for lower than their true values
		if randi_range(1, 8) == 4:
			fish_instance.current_price = fish_details.price / 3
			if Global.underpriced_upgrade_bought:
				fish_instance.details_label.label_settings = DETAILS_LABEL_UNDERPRICED
		else:
			fish_instance.current_price = fish_details.price
		fish_instance.fish_resource = fish_resource_current
		fish_instance.icon_texture.texture = Global.fish_queue[Global.queue_position].fish_resource.fish_icon
		if fish_details.unique:
			fish_instance.details_label.text = "{0}".format([fish_resource_current.name])
		else:
			fish_instance.details_label.text = "{0} {1}{2}-{3}D-{4}".format([fish_resource_current.name, fish_details.size_value, fish_resource_current.weight_measurement_shorthand, fish_details.expiration_date, fish_details.alive_title.left(1)])
		Global.queue_position += 1
		displayed_fish_changed.emit()
		for offer: Node in Global.selected_offers:
			if Global.is_offer_completable_with_item(offer.offer_selected, fish_details):
				fish_instance.star_texture.visible = true
				break
			else:
				fish_instance.star_texture.visible = false
		if Global.money <= fish_instance.current_price:
			change_turn_buttons_state(true, Control.CURSOR_ARROW)
		else:
			change_turn_buttons_state(false, Control.CURSOR_POINTING_HAND)
		_on_update_prices()

func change_turn_buttons_state(disabled: bool, cursor_choice: Control.CursorShape) -> void:
	bid_30.disabled = disabled
	bid_30.mouse_default_cursor_shape = cursor_choice

func _on_bid_30_pressed() -> void:
	bid_on_fish(1.3)

func reset_ai_money() -> void:
	for ai in $AITurns.ais:
		ai.money = (750 * Global.player_level) if Global.player_level > 0 else 750

func _on_ai_turn_made() -> void:
	price_increased.emit(fish_instance.current_price)
	fish_instance.current_price *= 1.3
	_on_update_prices()
	fish_instance.add_theme_stylebox_override("panel", ITEM_PLAYER_LOSING)
	$AuctionTimer.start($AuctionTimer.time_left + 1)
	if bid_30.disabled and Global.money >= int(fish_instance.current_price * 1.3):
		change_turn_buttons_state(false, CURSOR_POINTING_HAND)

func _on_update_prices() -> void:
	bid_30.text = "Bid: ${0}".format([int(fish_instance.current_price * 1.3)])
	fish_instance.price_label.text = "${0}".format([fish_instance.current_price])
	if Global.money < fish_instance.current_price * 1.3:
		change_turn_buttons_state(true, Control.CURSOR_ARROW)

# used to have a way to bid 50%, just decided to leave this here even though its now only for one button
func bid_on_fish(percentage_paid: float) -> void:
	var current_price_update: int = int(fish_instance.current_price * percentage_paid)
	if Global.money >= current_price_update:
		price_increased.emit(fish_instance.current_price)
		fish_instance.current_price = current_price_update
		_on_update_prices()
		fish_instance.add_theme_stylebox_override("panel", ITEM_PLAYER_WINNING)
		$AuctionTimer.start($AuctionTimer.time_left + 1)
		$AITurns.bid_history.append(self)
		Global.money_label_queue(Global.money - current_price_update, DEFAULT_LABEL_BAD)
		change_turn_buttons_state(true, Control.CURSOR_ARROW)
		if $AITurns.top_ai:
			$AITurns.top_ai.profile_container.add_theme_stylebox_override("panel", $AITurns.AI_LOSING)
			$AITurns.top_ai = null

func update_steve_icon() -> void:
	steve_ai.texture_rect.texture = AI_ICON_1_BLUSH if Global.chocolate_bought else AI_ICON_1

func _on_price_increased(price_change: int) -> void:
	var popup_label_instance: Label = POPUP_LABEL.instantiate()
	add_child(popup_label_instance)
	popup_label_instance.text = "+${0}".format([int(price_change * 0.3)])
	popup_label_instance.position = Vector2(randi_range($Bid30.position.x, $Bid30.position.x + $Bid30.size.x), randi_range($Bid30.position.y, $Bid30.position.y + $Bid30.size.y))
	popup_label_instance.add_theme_color_override("font_color", Color("#4dce59"))
	# i hate radians
	popup_label_instance.rotation = deg_to_rad(randi_range(-15, 15))

func _on_auction_timer_timeout() -> void:
	$AnimationPlayer.play("time_disappear")
	fish_instance.animation_player.play("auction_close")
	change_turn_buttons_state(true, Control.CURSOR_ARROW)
	if not $AITurns.bid_history.is_empty():
		if $AITurns.bid_history.back().participant_name == Global.player_name:
			Global.money_label_queue(Global.money - int(fish_instance.current_price), DEFAULT_LABEL)
			Global.update_money(Global.money - int(fish_instance.current_price))
			Global.set_notification("You won a {0}!".format([fish_instance.fish_resource.name]), Global.DEFAULT_LABEL_GOOD)
			Global.items_held.append(fish_details)
			Global.increase_exp(int(fish_instance.current_price / 20))
		else:
			# deduct the winning ais money
			Global.money_label_queue(Global.money, DEFAULT_LABEL)
			$AITurns.top_ai.money -= int(fish_instance.current_price)
	fish_instance.add_theme_stylebox_override("panel", ITEM_UNCHANGED)
	$SoldLabel.text = "PASSED" if $AITurns.bid_history.is_empty() else "SOLD"
	# clears bid history, top_ai and stops the ai timer
	end_round.emit()
	fish_instance.details_label.label_settings = DETAILS_LABEL
	Global.update_offer_button()

func _on_auction_animation_finished() -> void:
	sold_label_animation_player.play("sold_label_appear")

func _on_sold_label_animation_finished(anim_name: StringName) -> void:
	if anim_name == "sold_label_appear":
		sold_label_animation_player.play("sold_label_disappear")
	elif anim_name == "sold_label_disappear" and Global.queue_position < Global.fish_queue.size():
		await get_tree().create_timer(0.2).timeout
		fish_instance.hidden_panel.visible = false
		load_fish_details()
		update_auction_label.emit()
		round_started.emit()
		$AuctionTimer.start(AUCTION_TIME)
		$AnimationPlayer.play("time_appear")
	# if there have been as many auctions as the max (the auction has ended)
	else:
		fish_instance.visible = false
		$Bid30.visible = false
		$AuctionTimer.stop()
		fish_instance.hidden_panel.visible = false
		end_auction.emit()
		reset_ai_money()
		change_turn_buttons_state(false, Control.CURSOR_POINTING_HAND)
