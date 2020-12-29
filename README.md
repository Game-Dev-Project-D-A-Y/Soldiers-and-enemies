# Unity week 6: Soldiers & Facility
     
<img src= https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/explosion.jpeg width="600" />   

## [PLAY ON ITCH](https://game-dev-project-d-a-y.itch.io/exgame)    

### We chose to do the following:    
     
#### Part 1
<img src= https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/1.jpg width="600" heigt="200" />   
    
By adding an   [SerializeField] KeyCode keyToChangeSpeed and chosing manually which button we want to activate the running, we were easly able to change the speed of the
player with one if staement. You may see all in our [CharacterKeyboardMover Script](https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/Assets/Scripts/1-player/CharacterKeyboardMover.cs)    
      
      
#### Part 2      
<img src= https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/2.jpg width="600" heigt="200" />       
    
We downloaded a few assets inckuding the grenade prefab and am explosion pack.     
There are two scripts that are relevent.   
[LaunchGrenade Script](https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/Assets/Scripts/4-ex-scripts/LaunchGrenade.cs) - incharge of spawning a grenade everytime the 'Q' is pressed.   
[GrenadeScript Script](https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/Assets/Scripts/4-ex-scripts/GrenadeScript.cs) - has a delay before it enters a function which checks for enemies in a specific distance from its location, instantiate an explotion which we added through a GameObject member and eventully destroying the grenade and with ParticleSystem we stopped the effect to contiue.
      
           
 #### Part 3     
<img src= https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/3.jpg width="600" heigt="200" />   
    
To each lamp thats on the map (which we added from the assets store..) we added a [turnStreetLightScript](https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/Assets/Scripts/4-ex-scripts/turnStreetLightScript.cs) which gets the GameObject light (a child of the lamp) and when pressed with 'E' it checks its status with a simple bool memnber and changes its status.    
     
         
#### Part 4
<img src= https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/4.jpg width="600" heigt="200" />    
      
[CowardRunner](https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/Assets/Scripts/4-ex-scripts/CowardRunner.cs) - Searches the furthers disttance from the playe from the targets     
[BraveRunner](https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/Assets/Scripts/4-ex-scripts/BraveRunner.cs) -  Searches the closest disttance from the playe from the targets         
[ChaseRunner](https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/Assets/Scripts/4-ex-scripts/ChaserRunner.cs) -  Gets the location of the player and transforms the postision towards the player  
[EngineRunner](https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/Assets/Scripts/4-ex-scripts/EngineRunner.cs) - Gets the location of the Engine and soon as it gets to the Engine we shutdown the light through the ParticleSystem    
     
<img src= https://github.com/Game-Dev-Project-D-A-Y/soldiers-and-enemies/blob/master/boomboom.jpg width="600" />   





