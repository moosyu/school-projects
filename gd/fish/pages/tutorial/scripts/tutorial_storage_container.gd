extends PanelContainer

@onready var storage_empty_label: Label = $MarginContainer/PanelContainer/StorageEmptyLabel
@onready var storage_item: PanelContainer = $MarginContainer/PanelContainer/ItemListScrollContainer/GridContainer/StorageItem

func _ready() -> void:
	if TutorialGlobal.has_fish:
		storage_empty_label.visible = false
		storage_item.visible = true
	storage_item.connect("storage_details_hovered", Callable(get_tree().current_scene.get_node("TutorialTooltip"), "_on_item_hovered_details"))
	storage_item.connect("storage_details_entered", Callable(get_tree().current_scene.get_node("TutorialTooltip"), "_on_entered_details"))
	storage_item.connect("storage_details_exited", Callable(get_tree().current_scene.get_node("TutorialTooltip"), "_on_exited_details"))
