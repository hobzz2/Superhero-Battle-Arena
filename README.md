# Superhero Battle Arena

A simple C# console application. The project simulates a turn-based battle system to demonstrate core Object-Oriented Programming concepts.

## Theme & Heroes

### Theme: ***"The Office"***

I chose a custom theme based on the hit show's characters for the hero roster:

* **Prison Mike (Warrior):** High health, steady physical damage. Uses "The Dementors" as a special power.
* **Dwight Schrute (Mage):** Lower health but high magic damage. Casts the "Beetroot Curse".
* **Jim Halpert (Archer):** Ranged attacker. Throws perfectly aimed snowballs.

## How it Works

1. The program initializes the heroes using parameterized constructors and stores them in a List.
2. The user is prompted to select an attacker and a target from the console menu.
3. The attacker calls the overridden `Attack()` method, which applies unique damage and prints a character-specific message.
4. The target's health is reduced (managed via encapsulated properties), and the console displays if the character is still alive or defeated.
