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

NOTE: This project was developed while / for using Unity 6


Vehicles Currently "Completed" & Included:
------------------------------------------


* Police Charger (x4) (controller, speedometer, entry) - [Functional]
* Swat Van (x4) (controller, speedometer, entry) - [Functional]
* Police Helicopter (x4) (controller, hud, entry) - [Functional] Note: (the helicopter entry scripts that are currently provided are "as is" simply for start point)

 
Other Currently "In Progress" & Not Yet Included:
--------------------------------------------------


Possible future additions: (if and or when my limited free time and desire may allow)

* Gas Station / Fuel System (0% Completed) coming TBA...
* Engine Audio (0% Completed) coming TBA...
* Horn Audio (0% Completed) coming TBA...
* Reverse Beeps Audio (0% Completed) coming TBA...
* Siren Audio (0% Completed) coming TBA...
* Exhaust Particles (0% Completed) coming TBA...
* Related Documentation(s) for above (0% completed) coming TBA...


Player Controls: 
----------------


  Note: The following found below are related to the provided playercontrol script for usage example if say using vehicle entry script.


* Player Forward:   W
* Player Reverse:   S
* Player Left:      A
* Player Right:     D
* Player Jump:      Space
* Player Sprint:    Left Shift


Vehicle Controls: 
-----------------


  Note: The following below are related to both variations either standalone vehicle controller usage and entry script usage.


* Vehicle Forward:  W
* Vehicle Reverse:  S
* Turn Left:        A
* Turn Right:       D
* Apply Brake:      Space


Entry Script: 


  Note: The following found below are specific only when entry script is applied.


* Enter Vehicle:    E
* Exit Vehicle:     F


Manual Setup Instruction:
-------------------------

Simply follow the documentation instruction linkages for manual setups found below.


PlayerControl:
--------------

* Example player control documentation: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/PlayerControl/Documentation/PlayerControl-Documentation.txt


Unity 6 Bug (Related to Wheel Colliders and Center of Gravity Offset) 
----------------------------------------------------------------------


NOTE: There is currently a bug in Unity 6 prior to Fixed in Unity 6
(6000.025f1) that affects wheel colliders and center of gravity offset. This
bug has been reported and is listed as a bug and is currently being worked on
for an official fix. Until such we can provide a temporary resolution file to
add to your vehicle to sort this out.


* Temporary Unity 6 Bug Resolution: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Temporary-Resolution/Unity-6-Temporary-Resolve-Bug.txt


ATTENTION!!: This bug has been fixed in Unity 6 (6000.025f1) thus this
temporary resolution is not needed if you upgrade to that version!


Vehicles Control:
-----------------


* All vehicles with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/Documentation/AllVehicleControllers-wEntry-Documentation.txt


Police Charger: (total: 4)
--------------------------

* Police Charger 01 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger01/Documentation/PoliceCharger01Controller-Only-Documentation.txt

* Police Charger 01 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger01/Documentation/PoliceCharger01Controller-wEntry-Documentation.txt

* Police Charger 01 controller only in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/PoliceCharger/PoliceCharger01/Documentation/PoliceCharger01Controller-Speedometer-Documentation.txt

* Police Charger 01 controller with entry in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger01/Documentation/PoliceCharger01Controller-Spedometer-Documentation.txt

* Police Charger 02 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger02/Documentation/PoliceCharger02Controller-Only-Documentation.txt

* Police Charger 02 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger02/Documentation/PoliceCharger02Controller-wEntry-Documentation.txt

* Police Charger 02 controller only in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/PoliceCharger/PoliceCharger02/Documentation/PoliceCharger02Controller-Speedometer-Documentation.txt

* Police Charger 02 controller with entry in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger02/Documentation/PoliceCharger02Controller-Spedometer-Documentation.txt

* Police Charger 03 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger03/Documentation/PoliceCharger03Controller-Only-Documentation.txt

* Police Charger 03 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger03/Documentation/PoliceCharger03Controller-wEntry-Documentation.txt

* Police Charger 03 controller only in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/PoliceCharger/PoliceCharger03/Documentation/PoliceCharger03Controller-Speedometer-Documentation.txt

* Police Charger 03 controller with entry in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger03/Documentation/PoliceCharger03Controller-Spedometer-Documentation.txt

* Police Charger 04controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger04/Documentation/PoliceCharger04Controller-Only-Documentation.txt

* Police Charger 04 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger04/Documentation/PoliceCharger04Controller-wEntry-Documentation.txt

* Police Charger 04 controller only in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/PoliceCharger/PoliceCharger04/Documentation/PoliceCharger04Controller-Speedometer-Documentation.txt

* Police Charger 04 controller with entry in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/PoliceCharger04/Documentation/PoliceCharger04Controller-Spedometer-Documentation.txt

* All Police Chargers with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceCharger/Documentation/AllPoliceChargerControllers-wEntry-Documentation.txt


Police Helicopter: (total: 4)
-----------------------------

* Police Helicopter 01 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/PoliceHelicopter01/Documentation/PoliceHelicopter01Controller-Only-Documentation.txt

* Police Helicopter 01 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/PoliceHelicopter01/Documentation/PoliceHelicopter01Controller-wEntry-Documentation.txt

* Police Helicopter 02 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/PoliceHelicopter02/Documentation/PoliceHelicopter02Controller-Only-Documentation.txt

* Police Helicopter 02 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/PoliceHelicopter02/Documentation/PoliceHelicopter02Controller-wEntry-Documentation.txt

* Police Helicopter 03 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/PoliceHelicopter03/Documentation/PoliceHelicopter03Controller-Only-Documentation.txt

* Police Helicopter 03 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/PoliceHelicopter03/Documentation/PoliceHelicopter03Controller-wEntry-Documentation.txt

* Police Helicopter 04 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/PoliceHelicopter04/Documentation/PoliceHelicopter04Controller-Only-Documentation.txt

* Police Helicopter 04 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/PoliceHelicopter04/Documentation/PoliceHelicopter04Controller-wEntry-Documentation.txt

* All Police Helicopters with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/PoliceHelicopter/Documentation/AllPoliceHelicoptersDevScene-wEntry-Documentation.txt


Swat Van: (total: 4)
--------------------

* Swat Van 01 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan01/Documentation/SwatVan01Controller-Only-Documentation.txt

* Swat Van 01 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan01/Documentation/SwatVan01Controller-wEntry-Documentation.txt

* Swat Van 01 controller only in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SwatVan/SwatVan01/Documentation/SwatVan01Controller-Speedometer-Documentation.txt

* Swat Van 01 controller with entry in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan01/Documentation/SwatVan01Controller-Spedometer-Documentation.txt

* Swat Van 02 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan02/Documentation/SwatVan02Controller-Only-Documentation.txt

* Swat Van 02 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan02/Documentation/SwatVan02Controller-wEntry-Documentation.txt

* Swat Van 02 controller only in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SwatVan/SwatVan02/Documentation/SwatVan02Controller-Speedometer-Documentation.txt

* Swat Van 02 controller with entry in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan02/Documentation/SwatVan02Controller-Spedometer-Documentation.txt

* Swat Van 03 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan03/Documentation/SwatVan03Controller-Only-Documentation.txt

* Swat Van 03 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan03/Documentation/SwatVan03Controller-wEntry-Documentation.txt

* Swat Van 03 controller only in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SwatVan/SwatVan03/Documentation/SwatVan03Controller-Speedometer-Documentation.txt

* Swat Van 03 controller with entry in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan03/Documentation/SwatVan03Controller-Spedometer-Documentation.txt

* Swat Van 04 controller only in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan04/Documentation/SwatVan04Controller-Only-Documentation.txt

* Swat Van 04 controller with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan04/Documentation/SwatVan04Controller-wEntry-Documentation.txt

* Swat Van 04 controller only in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SwatVan/SwatVan04/Documentation/SwatVan04Controller-Speedometer-Documentation.txt

* Swat Van 04 controller with entry in scene speedometer setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/SwatVan04/Documentation/SwatVan04Controller-Spedometer-Documentation.txt

* All Swat Vans with entry in scene setup:  https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyHeist/blob/main/Unity-6/Assets/VehiclesControl/SwatVan/Documentation/AllSwatVanControllers-wEntry-Documentation.txt