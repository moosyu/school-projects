extends Control

var titles: Array = ["Fonts", "Fish icons:"]
var details: Array = ["BM kkubulim - Woowa Brothers
friendlyscribbles - kmlkmljkl
Cubular - darkosparko", "Herring icon - Liza Khlebnikova
Salmon icon - Milton Love
Tuna icon - Hotel Kaesong
Catfish icon - Usien
Carp icon - Fabio Poggi"]

func _ready() -> void:
	$TitleLabel.text = "{0}:".format([titles[0]])
	$DetailsLabel.text = details[0]
