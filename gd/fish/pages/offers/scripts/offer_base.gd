extends Resource
class_name OfferBase

@export var sender: String
@export var intro: String
@export_multiline var details: String
@export var requirement: ItemBase
@export var required_size: int
@export var required_alive: bool
@export var level_requirement: int
@export var has_requirements: bool = true
@export var money_reward: int
@export var exp_reward: int
@export var repeatable: bool
