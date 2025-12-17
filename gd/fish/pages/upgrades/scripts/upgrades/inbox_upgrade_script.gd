extends UpgradeBase
class_name InboxUpgrade

func apply_upgrade() -> void:
	Global.update_money(Global.money - price)
	level += 1
	price *= 2
	Global.max_offers_selectable += 1
	Global.update_selected_size()
