extends PanelContainer

const UPGRADE_ITEM: PackedScene = preload("res://pages/upgrades/scenes/upgrade_item.tscn")

func _ready() -> void:
	for upgrade: UpgradeBase in Global.available_upgrades:
		var upgrade_item_instance = UPGRADE_ITEM.instantiate()
		upgrade_item_instance.upgrade = upgrade
		$UpgradesList.add_child(upgrade_item_instance)
