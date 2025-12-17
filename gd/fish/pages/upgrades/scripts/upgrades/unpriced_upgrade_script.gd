extends UpgradeBase
class_name HighlightUnderpricedUpgrade

func apply_upgrade() -> void:
	Global.update_money(Global.money - price)
	level += 1
	Global.underpriced_upgrade_bought = true
