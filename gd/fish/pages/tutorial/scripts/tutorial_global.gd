extends Node

var selected_offer: bool = false
var has_fish: bool = false
var viewed_offer_popup: bool = false
var viewed_storage_popup: bool = false
var viewed_offer_selection_popup: bool = false
var viewed_offer_deselection_popup: bool = false
var viewed_auction_popup: bool = false
var viewed_catalog_popup: bool = false

signal popup_spawn

func spawn_popup(popup_text: String) -> void:
	popup_spawn.emit(popup_text)

func reset_values() -> void:
	selected_offer = false
	has_fish = false
	viewed_offer_popup = false
	viewed_storage_popup = false
	viewed_offer_selection_popup = false
	viewed_offer_deselection_popup = false
	viewed_auction_popup = false
	viewed_catalog_popup = false
