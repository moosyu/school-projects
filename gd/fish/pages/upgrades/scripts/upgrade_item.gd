extends PanelContainer

@onready var title_label: Label = $MarginContainer/HBoxContainer/TitleLabel
@onready var buy_upgrade: Button = $MarginContainer/HBoxContainer/BuyUpgrade

var price: int
var upgrade: UpgradeBase

func _ready() -> void:
	load_upgrade()

func _on_buy_upgrade_pressed() -> void:
	upgrade.apply_upgrade()
	load_upgrade()

func load_upgrade() -> void:
	if upgrade.max_level > 1:
		var title_level: String = str(upgrade.level)  if upgrade.level < upgrade.max_level else "MAX"
		title_label.text = "{0} - Level: {1}".format([upgrade.upgrade_name, title_level])
	else:
		title_label.text = "{0}".format([upgrade.upgrade_name])
	price = upgrade.price
	buy_upgrade.text = "Buy: ${0}".format([upgrade.price])
	buy_upgrade.disabled = Global.money < upgrade.price
	if Global.money < upgrade.price:
		buy_upgrade.mouse_default_cursor_shape = Control.CURSOR_ARROW
	else:
		buy_upgrade.mouse_default_cursor_shape = Control.CURSOR_POINTING_HAND
	if upgrade.level == upgrade.max_level:
		buy_upgrade.queue_free()
