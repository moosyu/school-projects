class_name OfferGenerator

func generate() -> OfferBase:
	var offer_selected: OfferBase = Global.available_offers.pick_random()
	if not offer_selected.requirement:
		offer_selected.requirement = Global.available_fish.pick_random()
	if not offer_selected.requirement.always_spawnable:
		Global.unique_fish_queue.append(offer_selected.requirement)
	Global.available_offers.erase(offer_selected)
	return offer_selected
