
LEO: Low Earth Orbiting Satellites X Madness

Objective: using a radio choose proper transmission bandwidth (color) to reach the satellite overhead that corresponds to the receiving bandwidth (color) of the antenna being revealed over the horizon.

Complexity factors: speed of earth rotation, frequency and abundance of antennas coming over horizon, numbers of different satellites and their  actual pass tracking

Problems encountered during Global Game Jam 2018 – Lusaka
	(resolved) Antenna receiver needed to be locked to the surface of the earth and then appear on 	the  eastern horizon

	Laser beam needs to be aimed at the satellite and fired, revealing a line/beam and then be 	reflected or relayed to the receiver antenna

	One of the  team lost access to the project using Unity on GitHub Desktop 

	Collaboration through GitHub wasn’t as smooth as we wished
		We ended up emailing, using flash drives, etc. to collaborate; and, it sure would have 			been nice to be able to collaborate more fluidly

Characters:
	Earth – spins east to west, with north “up”

	Satellites – four different Sats with 4 colors; points are made with successful transmissions
		Green: corresponds with xbox button A; 20 points
		Blue: corresponds with xbox button X; This is a rare satellite worth 30 points
		Yellow: corresponds with xbox button Y; 10 points
		Red: corresponds with xbox button B; 10 points
	
	Antennas - correspond to the four satellites
		Green
		Blue
		Yellow
		Red
		
	Radio - main character
		Moves with arrows globe [note: in the future we want to use game controllers]

	Alien enemy – optionally fires laser beams to randomly destroy some antennas in later 				stages of the game

Textures & Sounds:
	Earth map, like “blue marble” files
	Space texture/stars
	Sound for radio sending
	Sound for satellite reception
	Sound for antenna reception
	Sound for enemy laser
	Sound for antenna destruction

Game levels:

	Level 1: 	Earth rotates slowly and satellites show up on same band as the receiver, easy to 				coordinate transmission – Point values are 1:1

	Level 2:	Earth rotates at 1/3 increase speed, some satellites start showing up to complicate  			choice of bandwidth – Point values are 1.5:1

	Level 3:	Earth rotate at ½ increase of speed, satellites of many bandwidths, speed of 				satellites increases. (For added complexity, time allowing, enemy space ship fires 			laser beams at the antennas destroying some – Point values are 2:1
Future Innovations: 

	Penalize for missing satellites at higher levels of play
		Perhaps by using a life bar

	Character moves on two axes on the surface of the earth.  In the future, it would be good to have 	that main character only on the land masses.  So as to be controlled and “jumping” from 	continent to continent via land bridges or short hops.
