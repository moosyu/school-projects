extends Node

const BID_TIME_ADDITION: int = 2
const BID_PRICE_MULTIPLIER: float = 1.3
const ITEM_SPAWN_COUNT: int = 10
const DEFAULT_LABEL: LabelSettings = preload("res://styles/default_label.tres")
const DEFAULT_LABEL_GOOD: LabelSettings = preload("res://styles/default_label_good.tres")
const DEFAULT_LABEL_BAD: LabelSettings = preload("res://styles/default_label_bad.tres")
const DEFAULT_LABEL_UNIQUE: LabelSettings = preload("res://styles/default_label_unique.tres")

var money: int = 1000
var day: int = 1
var mercy: int = 0
var player_exp: int = 0
var player_level: int = 0
var player_name: String = "Placeholder"
var items_held: Array[Dictionary]
var expenses: int = 100
var rewards_queue: Array
var fish_resources: Array[ItemBase]
var available_fish: Array[ItemBase]
var fish_queue: Array[Dictionary]
var unique_fish_queue: Array[ItemBase]
var offer_resources: Array [OfferBase]
var available_offers: Array[OfferBase]
var selected_offers: Array[Node]
var finished_offers: Array[OfferBase]
var max_offers_selectable: int = 3
var upgrade_resources: Array[UpgradeBase]
var available_upgrades: Array[UpgradeBase]
var catalog_hidden: bool = true
var chocolate_bought: bool = false
var underpriced_upgrade_bought: bool = false
var queue_position: int = 0
var opened_offer: OfferBase
var day_notification_queue: Array[String]
var game_time: float
var game_started: bool

signal notification_updated
signal update_complete_button
signal money_changed
signal money_change_queued
signal exp_changed
signal turn_changed
signal selected_size_changed
signal day_notification_notification

func _ready() -> void:
	offer_resources = load_offers("res://resources/offers/")
	fish_resources = load_fish("res://resources/fish/")
	upgrade_resources = load_upgrade("res://resources/upgrades/")

func _process(delta: float) -> void:
	if game_started:
		game_time += delta

func load_offers(path: String) -> Array[OfferBase]:
	var loaded_offers: Array[OfferBase]
	for file in DirAccess.open(path).get_files():
		var offer = load(path + "/" + file)
		if offer is OfferBase:
			loaded_offers.append(offer)
	return loaded_offers

func load_fish(path: String) -> Array[ItemBase]:
	var loaded_fish: Array[ItemBase]
	for file in DirAccess.open(path).get_files():
		var fish = load(path + "/" + file)
		if fish is ItemBase:
			loaded_fish.append(fish)
	return loaded_fish

func load_upgrade(path: String) -> Array[UpgradeBase]:
	var loaded_upgrades: Array[UpgradeBase]
	for file in DirAccess.open(path).get_files():
		var upgrade = load(path + "/" + file)
		if upgrade is UpgradeBase:
			loaded_upgrades.append(upgrade)
	return loaded_upgrades

func update_offer_button() -> void:
	update_complete_button.emit()

func update_money(new_money: int) -> void:
	money = new_money
	money_changed.emit()

func increase_exp(exp_increase: int) -> void:
	player_exp += exp_increase
	exp_changed.emit()

func set_notification(text: String, label_settings: LabelSettings) -> void:
	notification_updated.emit(text, label_settings)

func set_day_notification(text: String) -> void:
	day_notification_queue.append(text)

func load_eligible_offers() -> Array[OfferBase]:
	var eligible_offers: Array[OfferBase]
	for offer in offer_resources:
		if not offer.requirement:
			offer.requirement = available_fish.pick_random()
		if not finished_offers.has(offer) and offer.level_requirement <= player_level:
			eligible_offers.append(offer)
	return eligible_offers

func load_eligible_fish() -> Array[ItemBase]:
	var eligable_fish: Array[ItemBase]
	for item in fish_resources:
		if item.level_requirement <= player_level and item.always_spawnable:
			eligable_fish.append(item)
	return eligable_fish

func money_label_queue(new_total: int, label_settings: LabelSettings) -> void:
	money_change_queued.emit(new_total, label_settings)

func update_selected_size() -> void:
	selected_size_changed.emit()

func is_offer_completable_with_item(offer: OfferBase, item: Dictionary) -> bool:
	if offer and item.fish_resource == offer.requirement and item.size_value >= offer.required_size and (not offer.required_alive or offer.required_alive == item.alive_value):
		return true
	else:
		return false

func reset_global() -> void:
	money = 1000
	day = 1
	mercy = 0
	player_exp = 0
	player_level = 0
	player_name = "Placeholder"
	items_held.clear()
	expenses = 100
	rewards_queue.clear()
	fish_resources.clear()
	available_fish.clear()
	fish_queue.clear()
	unique_fish_queue.clear()
	offer_resources.clear()
	available_offers.clear()
	selected_offers.clear()
	finished_offers.clear()
	max_offers_selectable = 3
	upgrade_resources.clear()
	available_upgrades.clear()
	catalog_hidden = true
	chocolate_bought = false
	underpriced_upgrade_bought = false
	queue_position = 0
	opened_offer.clear()
	day_notification_queue.clear()
	game_time = 0.0
	game_started = false
