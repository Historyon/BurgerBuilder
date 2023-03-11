# Burger Builder

Burger Builder is my first small game for learning purpose. It is created with the game engine godot. I want to create a simple game with some rules.

When you want to edit something please have a look inside [the setup section][Setup].

## General idea

You're playing Jim the burger builder. Jims task is to catch falling burger ingredients in a corret order and serve the builded burger the customers. Jim works in shift work so his time to build burgers is limited. In most cases customers will also eat burgers that are not builded as they whishes but pay less money for the burger. In some cases a customer will not pay for a builded burger. For example when the customer is a vegan and Jim serves a burger with meat from animals.

## First Look

The following image shows you what I've planned what the game is about and should look like.

![FirstLook]

Number | Description
--- | ---
1 | In the upper left corner the blueprint for the current requested burger is shown
2 | This is the player (Jim). He can be moved to the left and right
3 | The burger plate and the burger the player is building. When a ingredient hits the plate it'll be added to the burger
4 | These are the ingredients which are falling down and can be catched by the players plate. There are different kinds of ingredients. Their are some special ingredients which have a influence to the gameplay. For further information have a look into [the Rules of the Game][Rules]
5 | This is the position of the customer. The player needs to deliver the burger to this position when it's ready
6 | The timer shows the player how much time is left to build burgers
7 | Customers pay money for burgers. They'll pay more money when the burger is builded correctly and nothing when the burger contains a personal no-go for them. For more information what no-gos existing have a look into [the Rules of the Game][Rules]

## Rules

This section describes all rules of the game. This rules should be found in the finished game. Changes can be done to this rules when I decide that it would make more sense or fun with different rules.

### Player

* The player can move from the left to the right
  * The area where the player can walk is limited
    * The left limit is the table of the customer
    * The right limit is the game window
* The player carries the burger plate with the burger on it
* When the player moves completly to the left the burger is delivered to the customer

### Plate

* The plate has a hitbox
  * When a ingredient hits the hitbox of the plate it is added to the burger
  * The hitbox of the plate is not changed by the burger on it

### Burger

* The maximum size of a burger is ten ingredients including bread
  * Ingredients can only be added and not be removed from the burger
  * After delivering the burger to the customer the burger has again zero ingredients

### Burger blueprint

* The minimum size of a burger blueprint contains four ingredients
* The maximum size of a bruger blueprint contains eight ingredients

### Customer/Delivery/Payment

* A burger with zero ingredients cannot be delivered
* Each ingredient which is shown in the blueprint and is contained in the burger add 1€ to the burger bill
* A perfect burger, when the burger looks like the one shown in the blueprint, add additional 2€ to the burger bill
* Ingredients which are not shown in the blueprint and are not special ingredients remove -1€ from the burger bill
* As long the burger does not contain a no-go and it contains at least the same amount as shown in the blueprint the customer will pay 1€
  * It does not matter when the burger bill is negative
* When the burger contains not enough ingredients the customer will pay 0€
  * It does not matter when the burger bill is negative
* When the burger contains a no-go the player loose 2€ for damage payment

### Ingredients

* Normal ingredients
  * Bread
  * Ketchup
  * Cheese
  * Meat-Patty
  * Vegan-Patty
  * Lettuce
  * Onion
* No-gos
  * A patty is a no-go for a vegan only customer
  * A vegan-patty is a no-go for a customer who wants only meat from animals

### Timer

* When the timer is running randomly ingredients fall to the ground
* By timeout no new ingredients will start to fall down
  * The player has the chance to deliver the last burger

### Remarks

* For corretion purpose is the maximum burger blueprint eight ingredients large but the burger itself can be ten ingredients large
* There are customers who want meat from animals and vegan meat


## Challenges

Their are some personal challenges that I need to find a solution for.

Challenge | Solution
--- | ---
Art | I'm a really bad artist so I'll have to look for some assets. The burger scenario with different ingredients might be too specific to look for. Maybe I need to create the ingredients by my own but can use free assets for the other things like the player, font and ofcourse music and sound
Motivation | That'll be the biggest challenge for me. I need to keep myself motivated to complete this game. Therfore I'm planning to work on days when I'm not motivated to proceed at least 30 minutes or an hour on this game.

## Tasks

- [ ] Setting up the godot project
- [ ] Implementation
  - [ ] Player movement
  - [ ] Adding falling ingredients
    - [ ] Ingredients should be random but in the blueprint shown ingredients should fall down more often
  - [ ] Adding plate with hitbox
    - [ ] When ingredients hitting the plate they have to be added to the burger
- [ ] Deliver burger to the customer on the left
  - [ ] When burger is delivered the quality of the burger needs to be calculated and the money needs to be added to the score 
- [ ] The timer
  - [ ] When the time is over they should not falling new ingredients
  - [ ] Ingredients falling at the moment should falling to the ground
  - [ ] When all ingredients passed the player the player should be moved to the customer automatically to deliver the last burger
  - [ ] Let player choose between three, four or five minutes
- [ ] Burger blueprint tile should show burger
- [ ] Art
  - [ ] Finding some free assets to use on the internet
  - [ ] Creating burger ingredient assets
- [ ] Start game screen
- [ ] Different resolutions

## Plans for the future

* Spend money
  * When the time is over the player could buy some upgrades like removing an ingredient, buying special ingredients which can also fall down from now on and make the burger more valuable
* Powerups
  * Having a slot for a powerup like walking faster
* Splitscreen or online multiplayer
  * I don't think that I'll build something like this into the game but it is maybe interesting for testing purpose

## Setup

To make potential cooperative work better the launch.json and task.json do not reference the Godot editor directly but using an environment variable.

```powershell
# Powershell
$Env:godotEditor = '<editor-path>'
```

[FirstLook]: Pitch/FirstLook.svg
[Rules]: #rules
[Setup]: #setup