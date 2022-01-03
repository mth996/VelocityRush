# VelocityRush
A multiplayer racing arcade game
Code description
The Network Manager Script works on the multiplayer functions and features in the game . First is the script is making a public variable to attach prefab, text and game objects. We can create a room, we need to connect to a photon server. After the game starts the player joins or creates a room in multiplayer which directly connects to the photon server and the player successfully joins or creates a room which will lead to the map selection. Here the player can choose any 4 maps of the game and the player joins other rooms or can go back and create a room so the player's friends can join his room. After joining can click ready and ready tick will choose and then can start the game.
4.Player Setup.cs              
The player setup determines which codes and game objects to turn on for the player and off it if it’s for the opponent  so that the players in multiplayers do not control each other’s cars. For example, CarController script will be activated if its for the player and it will be deactivated if it is for the opponent.
5. Multiplayer, Racing Game manager
The RacingModeGameManager is responsible to call the car prefab from the resources and assign them to their respectable start positions depending on which car has been selected.
6. Wheel Collider
The Wheel Collider is a collider for vehicles on ground which is known as a special collider. It has a collision detection, Physics and friction tire model. The objects which are not wheels then also are designed for vehicles.
The collision detection is performed by a ray from Center downwards through the Y-axis. The wheel has a Radius and will be able to extend downwards according to the Suspension Distance. Vehicle is controlled from scripting using different properties: motorTorque, brakeTorque and steerAngle.The Wheel Collider with the friction that is  separate from the rest of the physics engine, using a slip-based friction model. This allows for more realistic behaviour but also causes Wheel Colliders to ignore standard settings.
PUN Network
In “Velocity Rush” we have implemented the PUN which is available in asset stores. The player can play the multiplayer mode. The player can type any name they prefer and the login page is shown in the lobby in the game scene, before playing the player must login using his name. Then the player is taken to lobby and create or join the lobby and the player can join. After all the players have joined the master client or player can start the game after everyone is ready and before starting the game if the player wants to leave, then there is always a leave button for leaving the game and going back to lobby.
The figure 1 is the photo network setting where we can insert our App Id and App Chat Id which will make us connect to the photon server, next will add the app version . After everything is done the player will be able join and connect with other players, But should make sure that everyone is on the same server or same Dev region.
Gameplay Scripts
1. Emp Power up
Emp powerup is used to  delete the game object (EMP) when the  car collider comes in contact with a game object (EMP) and the trap is activated due to the function EmpStunEffect() which deactivates the controls of the car for a short period of time.
2. Nitro Controller
Nitro controller  is used for using the powerup which is stored in the car after collecting power up in the game. When RightShift Button is pressed this script checks whether nitro is available, if nitro available is true then a function NitroBoost is called which multiplies the motorForce by 1000f.
3. Nitro Power Up
Nitro powerup is used to  delete the game object (NitroPowerup) when the  car collider comes in contact with a game object (NitroPowerup)) and is stored in the car  and makes the nitro available to true.
4.Shield Controller
Shield controller  is used for using the powerup which is stored in the car after collecting power up in the game. When Tab Button is pressed this script checks whether Shield is available, if Shield available is true then a function EmpArmour is called which deactivates the Emp effect so if the car touches the Emp trap also the CarController will not be deactivated.
5. Shield Power up
Shield powerup is used to  delete the game object (ShieldPowerup) when the  car collider comes in contact with a game object (ShieldPowerup)) and is stored in the car  and makes the shield available to true.
6. Car Controller
7. Checkpoint system
The checkpoint systems have 2 different sets of scripts to handle their functions. One set deals with allowing the player to respawn back at the last checkpoint they go through, using the backspace key. This happens by having the position and rotation data of the checkpoint be copied onto the player, essentially transporting the player to the checkpoint with the orientation facing the right way. The scripts in this set are applied to both the checkpoints and the players.
The second set of scripts is where the multiplayer functions go. This set tracks each player’s progress through the checkpoints and whether or not they are going through the right ones. If the player goes through the wrong checkpoint, it won’t recognize that you went through it. 
The TrackCheckpoints script also holds the counter that keeps track of the number of laps that the player has gone through. Each player will be tracked through the carTransformList, while each checkpoint will be tracked through the checkpointSingleList. The player can only go through the checkpoints in the proper sequence, otherwise it would not register at all.
8. Respawn Controller
9, Brake light.cs
In the car controller Script WE are using a boolean to check if the car breaks or not, then we declare two public voids one is brakelightoff() another one is brakelighton() where we set it active. Then we use an if statement to check if braked = true then brakeighton() else brakelightoff().
10. Reset.cs
GameVariable.cs will store the last checkpoint transform.position value. Checkpoint.cs contain a box collider with a gamObject.tag “Checkpoint”, on trigger function that allows all pass through car stores their last checkpoint transform.position into GameVariable.cs. Reset.cs contain a function that sets transform.position into (0,0,0) value at start, it also sets transform.rotation value into (0,0,0) to reset the car model if flipped over. By pressing the R key in the keyboard it will perform a function that reset car transform.position to the last checkpoint and transform.,rotation into (0,0,0).
11. Health Bar
Health bar decreases when hit by an emp and changes from green to yellow to red respectively.
12. Health Powerup
Health powerup is used to  delete the game object (Health powerup) when the  car collider comes in contact with a game object (Health powerup) and the healing is activated due to the function HealthRegeneration() which gives the car full health.
