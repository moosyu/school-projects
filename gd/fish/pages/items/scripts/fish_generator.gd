class_name FishGenerator

var last_fish: ItemBase = null

func generate() -> Dictionary:
	var roll = randi_range(0, 9)
	var fish_resource: ItemBase
	var alive: bool
	var alive_title: String
	var size_value: int
	var expiration_date: int
	var price: int
	expiration_date = randi_range(1, 10)
	if roll <= 5 or Global.mercy >= 3:
		Global.mercy = 0
		#fish_resource = Global.selected_offers.pick_random().offer_selected.requirement
		fish_resource = pick_fish_from_offers()
	else:
		Global.mercy += 1
		fish_resource = pick_non_duplicate_fish()
	last_fish = fish_resource
	size_value = randi_range(fish_resource.minimum_weight, fish_resource.maximum_weight)
	if randi_range(0, 1) == 0:
		alive = false
		alive_title = "Dead"
	else:
		alive = true
		alive_title = "Alive"
	price = int(fish_resource.base_price * (float(size_value) / fish_resource.maximum_weight + 3) * randf_range(1, 3 + Global.player_level))
	return {"fish_resource": fish_resource, "unique": false, "alive_value": alive, "alive_title": alive_title, "size_value": size_value, "expiration_date": expiration_date, "price": price}

func pick_fish_from_offers() -> ItemBase:
	var filtered_fish = Global.selected_offers.filter(func(offer: Node) -> bool:
			return offer.offer_selected.requirement.always_spawnable and offer.offer_selected.requirement != last_fish)

	if filtered_fish.size() > 0:
		return filtered_fish.pick_random().offer_selected.requirement
	else:
		return pick_non_duplicate_fish()

func pick_non_duplicate_fish() -> ItemBase:
	var filtered_fish = Global.available_fish.filter(func(fish: ItemBase) -> bool:
		return fish != last_fish)
	return filtered_fish.pick_random()
