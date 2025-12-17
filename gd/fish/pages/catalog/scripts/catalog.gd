extends PanelContainer

const CATALOG_ITEM = preload("res://pages/catalog/scenes/catalog_item.tscn")
const SPECIAL = preload("res://assets/sprites/icons/special.png")
const QUESTION = preload("res://assets/sprites/icons/question.png")

var last_checked_fish_seen: int

func _ready() -> void:
	for fish: int in range(Global.fish_queue.size()):
		var catalog_item_instance = CATALOG_ITEM.instantiate()
		$GridContainer.add_child(catalog_item_instance)
		if not Global.fish_queue[fish].unique:
			catalog_item_instance.star_texture.texture = load(get_rarity_icon(Global.fish_queue[fish].price))
		else:
			catalog_item_instance.star_texture.texture = SPECIAL

func load_catalog() -> void:
	var catalog_items: Array[Node] = $GridContainer.get_children()
	if last_checked_fish_seen < Global.queue_position:
		for fish: int in range(last_checked_fish_seen, Global.queue_position):
			catalog_items[fish].fish_texture.texture =  Global.fish_queue[fish].fish_resource.fish_icon
	# when the round has changed
	elif last_checked_fish_seen > Global.queue_position:
		for fish: int in range(Global.queue_position, last_checked_fish_seen):
			catalog_items[fish].fish_texture.texture = QUESTION
			if not Global.fish_queue[fish].unique:
				catalog_items[fish].star_texture.texture = load(get_rarity_icon(Global.fish_queue[fish].price))
			else:
				catalog_items[fish].star_texture.texture = SPECIAL

	last_checked_fish_seen = Global.queue_position

func get_rarity_icon(price: int) -> String:
	var star_path: String = "res://assets/sprites/icons/{0}.png"
	if price >= 200 and price < 400:
		return star_path.format(["uncommon"])
	elif price >= 400 and price < 699:
		return star_path.format(["rare"])
	elif price >= 699 and price < 800:
		return star_path.format(["epic"])
	elif price >= 800:
		return star_path.format(["legendary"])
	else:
		return star_path.format(["common"])
