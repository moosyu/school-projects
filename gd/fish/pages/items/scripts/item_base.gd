extends Resource
class_name ItemBase

@export var name: String
@export var species: String
@export var fish_icon: Texture2D
@export var base_price: int
@export var fact: String
@export var price_multiplier: int = 1
@export var level_requirement: int = 0
@export var always_spawnable: bool = true
@export var minimum_weight: int
@export var maximum_weight: int
@export var weight_measurement_shorthand: String = "KG"
@export var weight_measurement_longhand: String = "kilogram"
