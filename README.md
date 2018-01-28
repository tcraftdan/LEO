
## LEO: Low Earth Orbiting Satellites X Madness
#
# Objective: using a radio choose proper transmission bandwidth (color) to reach the satellite overhead that corresponds to the receiving bandwidth (color) of the antenna being revealed over the horizon.
#
# Complexity factors: speed of earth rotation, frequency and abundance of antennas coming over horizon, numbers of different satellites and their  actual pass tracking
#
#Characters:
#	Earth – spins east to west, with north “up”
#
#	Satellites – four different Sats with 4 colors; points are made with successful transmissions
#		Green: corresponds with xbox button A; 20 points
#		Blue: corresponds with xbox button X; This is a rare satellite worth 30 points
#		Yellow: corresponds with xbox button Y; 10 points
#		Red: corresponds with xbox button B; 10 points
#
#	Antennas - correspond to the four satellites
#		Green
#		Blue
#		Yellow
#		Red
#		
#	Radio - main character
#		Moves north and south on a straight line on the globe
#
#	Alien enemy – optionally fires laser beams to randomly destroy some antennas in later stages of the game
#
# Textures & Sounds:
#	Earth map, like “blue marble” files
#	Space texture/stars
#	Sound for radio sending
#	Sound for satellite reception
3	Sound for antenna reception
#	Sound for enemy laser
#	Sound for antenna destruction
#
# Game levels:
#
#	Level 1: 	Earth rotates slowly and satellites show up on same band as the receiver, easy to 				coordinate transmission – Point # values are 1:1

#	Level 2:	Earth rotates at 1/3 increase speed, some satellites start showing up to complicate  			choice of bandwidth – Point values are 1.5:1
#
#	Level 3:	Earth rotate at ½ increase of speed, satellites of many bandwidths, speed of 				satellites increases. (For added complexity, time allowing, enemy space ship fires 		laser beams at the antennas destroying some – Point values are 2:1
# A game developed in Unity
# Player moves north and south, aims at unique satellites in order to reach receiver stations as they appear on globe
# Assets:
#   A huge selection of assets have been provided in this branch
#   a number of 3D handheld radios, and towers have been sent via email/google-drive-links
#   NASA 3D Satellites: https://nasa3d.arc.nasa.gov/search/satellite/
#   There are many other Assets that can be found for free at https://www.3dcadbrowser.com/
#   More free 3D models can be found at https://free3d.com/
# sounds and free music:
#   http://www.incompetech.com/
#   http://www.soundbible.com/
# creating orbit: https://www.youtube.com/watch?v=qCxbCqmW6vE
