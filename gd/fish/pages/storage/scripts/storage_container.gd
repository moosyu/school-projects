extends PanelContainer

const STORAGE_ITEM: PackedScene = preload("res://pages/storage/scenes/storage_item.tscn")

@onready var storage_items: GridContainer = $MarginContainer/PanelContainer/ItemListScrollContainer/GridContainer
@onready var storage_empty_label: Label = $MarginContainer/PanelContainer/StorageEmptyLabel

func _ready() -> void:
	if Global.items_held.is_empty():
		storage_empty_label.visible = true
	else:
		storage_empty_label.visible = false
		for fish_owned in Global.items_held:
			var item_instance: Node = STORAGE_ITEM.instantiate()
			# passing fish details over to the actual storage fish item so it can be used for tooltips and selling
			item_instance.fish_details = fish_owned
			storage_items.add_child(item_instance)
			item_instance.connect("storage_details_hovered", Callable(get_tree().current_scene.get_node("Tooltip"), "_on_item_hovered_details"))
			item_instance.connect("storage_details_entered", Callable(get_tree().current_scene.get_node("Tooltip"), "_on_entered_details"))
			item_instance.connect("storage_details_exited", Callable(get_tree().current_scene.get_node("Tooltip"), "_on_exited_details"))
