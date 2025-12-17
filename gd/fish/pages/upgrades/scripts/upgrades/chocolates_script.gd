extends UpgradeBase
class_name ChocolatesUpgrade

func apply_upgrade() -> void:
	Global.update_money(Global.money - price)
	level += 1
	Global.chocolate_bought = true
