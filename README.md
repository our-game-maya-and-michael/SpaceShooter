# Unity week 3
In this repository I changed the game of Erel and Maoz to my liking, the things I changed are:
* The game boundaries: to make it look like a circle game, when the player moves off screen to the right or left he teleport to the opposite side like in a circle universe [The script](https://github.com/our-game-maya-and-michael/SpaceShooter/blob/main/Assets/Scripts/1-movers/ObjectWarpAsCircle.cs)
* Adding 3 hit points: to make the game a little longer and fun I gave the player 3 lives, when he gets hit for the third life he gets destroyed and the game is over ! [The script](https://github.com/our-game-maya-and-michael/SpaceShooter/blob/main/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs)
* Cooldown time to the laser: to make the game a little more intersting and deficult I made a cooldown timer for the laser so that you cant just shoot forever the defualt is 0.5 seconds between each shot [The script](https://github.com/our-game-maya-and-michael/SpaceShooter/blob/main/Assets/Scripts/2-spawners/LaserShooter.cs)
* Adding a Ultimate: to add extra spice to the game I made a Ultiame that spawns every 15 seconds and kill the whole map and gives the player all the points for it ! [The script](https://github.com/our-game-maya-and-michael/SpaceShooter/blob/main/Assets/Scripts/3-collisions/UltimateEffect.cs)
[to play the game on itch.io](https://mayamichael.itch.io/spaceshooter-michael)
## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
