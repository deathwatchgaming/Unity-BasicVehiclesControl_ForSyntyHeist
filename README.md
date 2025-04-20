# Unity-BasicVehiclesControl_ForSyntyHeist
 

Description:
------------


Create basic Vehicle Controllers for your Unity projects using vehicle models
from Synty Polygon Heist Asset.

 Note: As this uses the vehicles from such and due to licensing such said vehicles cannot be included in this repository obviously, so, as such the provided scripts and instructions thus require having / purchasing the Synty Polygon Heist Asset:

 https://assetstore.unity.com/packages/3d/environments/urban/polygon-heist-low-poly-3d-art-by-synty-97949


Synty Heist Vehicles (total: 12)
--------------------------------


* Police Helicopter (total: 4)
* Police Charger (total: 4)
* Swat Van (total: 4)

![Preview](https://raw.githubusercontent.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/refs/heads/main/Previews/All/Heist-Vehicles.png)


Release Intentions Note:
------------------------


The intention of these releases due to only being scripts for usage with models one must already own or opt to purchase and as such was known that one could not release such models with the package here the intent was to provide basic vehicle functionality as a start point as fully functional in terms of an opinion of basic but leave out optional continuances in the hopes that these will be used as starting points for folks to continue on with and improve upon. Now, some of the things intentionally left out, umm, while all simply easy to add, lets see: say, audio sources, audio clips, particle systems for exhausts as leaving these initializations of such aforementioned suggestions out was indeed intentional in the hopes that the end user will continue to add those as desired and continue to improve upon the provided start points. Also note that while yes, these are great hints, tips and or suggestions, if you were thinking say of what to add next, please note though, that is not to say if and or when I may find myself to have free time say I just may or may not opt to add such or some of such at later dates if desire or free time allows. Another thing to note is that I intentionally left out adding a fuel system to these at this time because again the intent was to provide basic functional vehicle controllers as starting points. 

NOTE: This project was developed while / for using Unity 2021+ & 2022+ & Unity 6


Old_Input_System Directory NOTE:

NOTE: This currently still uses the Old Input System, so as such depending on what version of Unity you may be using it may be necessary to make sure such or both is enabled in project settings.

New_Input_System Directory NOTE:

NOTE: This currently uses the New Input System (ie: Unity 21 - 22 variant provided & Unity 6 version coming soon when I have further free time to do such), so as such depending on what version of Unity you may be using it may be necessary to make sure such or both is enabled in project settings.

New_Input_System Directory Documentations NOTE: If there is any confusion with any documentation during setup in regards to "Input Actions", just note the following "Input Action Assets" found below:

For player:

Input Actions:

Player Controls: PlayerControls (Input Action Asset)

For vehicles:

Input Actions:

Car Controls: CarControls (Input Action Asset)

Helicopter Controls: HelicopterControls (Input Action Asset)


Vehicles Currently "Completed" & Included:
------------------------------------------


* Police Charger (x4) (controller, speedometer, entry, compass) - [Functional]
* Swat Van (x4) (controller, speedometer, entry, compass) - [Functional]
* Police Helicopter (x4) (controller, hud, entry, compass) - [Functional] Note: (the helicopter entry scripts that are currently provided are "as is" simply for start point)



Other Currently "Completed" & Included:
---------------------------------------


* Player & Vehicles Compass


 
Other Current Possibles "In Progress" & Not Yet Included:
---------------------------------------------------------


Possible future additions: (if and or when my limited free time and desire may allow)

* Gas Station / Fuel System (0% Completed) coming TBA...
* Engine Audio (0% Completed) coming TBA...
* Horn Audio (0% Completed) coming TBA...
* Reverse Beeps Audio (0% Completed) coming TBA...
* Siren Audio (0% Completed) coming TBA...
* Exhaust Particles (0% Completed) coming TBA...
* Mesh Deformation (0% Completed) coming TBA...
* Related Documentation(s) for above (0% completed) coming TBA...


Player Controls: 
----------------


  Note: The following found below are related to the provided playercontrol script for usage example if say using vehicle entry script.


New_Input_System Variant:


* Player Forward:   W [Keyboard] / Left Stick [Gamepad]
* Player Reverse:   S [Keyboard] / Left Stick [Gamepad]
* Player Left:      A [Keyboard] / Left Stick [Gamepad]
* Player Right:     D [Keyboard] / Left Stick [Gamepad]
* Player Jump:      Space [Keyboard] / Button South [Gamepad] 
* Player Sprint:    Shift [Keyboard] / Left Shoulder [Gamepad]
* Player Look:      Delta [Mouse] / Right Stick [Gamepad]


Old_Input_System Variant:


* Player Forward:   W
* Player Reverse:   S
* Player Left:      A
* Player Right:     D
* Player Jump:      Space
* Player Sprint:    Left Shift
* Player Look:      Mouse


Vehicle Controls: 
-----------------


  Note: The following below are related to both variations either standalone vehicle controller usage and entry script usage.


New_Input_System Variant:


Cars:

* Vehicle Forward:   W [Keyboard] / Left Stick [Gamepad]
* Vehicle Reverse:   S [Keyboard] / Left Stick [Gamepad]
* Vehicle Left:      A [Keyboard] / Left Stick [Gamepad]
* Vehicle Right:     D [Keyboard] / Left Stick [Gamepad]
* Vehicle Brake:     Space [Keyboard] / Right Trigger [Gamepad]

Helicopters:

* Roll: A & D [Keyboard] / Left Stick [Gamepad]
* Pitch: S & W [Keyboard] / Left Stick [Gamepad] 
* Yaw:  Q & E [Keyboard] / Right Stick [Gamepad]
* Decrease throttle: Shift [Keyboard] / D-Pad Down [Gamepad]
* Increase throttle: Control [Keyboard] / D-Pad Up [Gamepad] 
* Change Cameras: V [Keyboard] / D-Pad Left [Gamepad] (ie: Rear Camera, Belly Camera & Cockpit Camera) 


Entry Script: 


  Note: The following found below are specific only when entry script is applied.


* Enter Vehicle:      E [Keyboard] / Button North [Gamepad] 
* Exit Vehicle:       F [Keyboard] / Button South [Gamepad] 


Old_Input_System Variant:  


Cars:

* Vehicle Forward:  W
* Vehicle Reverse:  S
* Turn Left:        A
* Turn Right:       D
* Apply Brake:      Space

Helicopters:

* Roll: A & D
* Pitch: S & W
* Yaw:  Q & E
* Decrease throttle: Left Shift
* Increase throttle: Left Control
* Change Cameras: V (ie: Rear Camera, Belly Camera & Cockpit Camera)


Entry Script: 


  Note: The following found below are specific only when entry script is applied.


* Enter Vehicle:    E
* Exit Vehicle:     F


Manual Setup Instruction:
-------------------------

Simply follow the linkages found below  for documentation information / instruction respective to the version say for example either Unity 2021+ & Unity 2022+ or Unity 6....


New_Input_System Variant:


* Unity 20221+ & 2022+ => Files, ReadMe, docs: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/tree/main/New_Input_System/Unity-2021-2022


* Unity 6 => Files, ReadMe, docs: coming soon...

Old_Input_System Variant:


* Unity 20221+ & 2022+ => Files, ReadMe, docs: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/tree/main/Old_Input_System/Unity-2021-2022


* Unity 6 => Files, ReadMe, docs: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Old_Input_System/Unity-6

