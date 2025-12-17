extends UpgradeBase
class_name ViewCatalogUpgrade

func apply_upgrade() -> void:
	Global.update_money(Global.money - price)
	level += 1
	Global.catalog_hidden = false
