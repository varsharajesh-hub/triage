MCI ENVIRONMENT ASSETS - KENNEY CAR KIT

CONTENTS
Complete FBX vehicle models, cones, crash debris and the shared colour texture.
Start with sedan.fbx, suv.fbx and ambulance.fbx. Vehicle models include their wheels.
Bus models are NOT included: the separate bus source could not be downloaded.

IMPORT INTO YOUR EXISTING UNITY PROJECT
1. Extract this ZIP outside your Unity project.
2. Drag the entire MCI_Vehicles folder into the Assets area of Unity's Project panel.
3. Wait for Unity to finish importing. Keep the Textures folder beside the FBX files.
4. Open MCI_Vehicles/Models and drag sedan into an empty area of the Hierarchy.
5. Inspect its size and colour before replacing any existing vehicle placeholder.

PLACEMENT
Keep Env_Crash, Crash_Environment, the road, zones and all CAS_01-CAS_10 objects.
Place and scale the imported vehicle first. Then hide only the corresponding old
body's Mesh Renderer. Do not delete a parent that holds your new model.
Match the car to the approximate 4.4 x 1.2 x 1.8 metre placeholder; imported models
can face a different direction and may require rotation and uniform scaling.
Do not put a new model under a stretched cube: the parent's scale distorts it.

UNITY URP COLOURS
These are source FBX models, not a Unity-tested URP package. Materials may need
adjustment in Unity 6.3. If a model is pink or untextured, create a new material
using Universal Render Pipeline/Lit, assign Models/Textures/colormap.png to Base
Map, then assign the material to the affected renderers. A FBX model may contain
several renderers. Do not change a shared road or zone material to fix a vehicle.

REUSE
Source: https://kenney.nl/assets/car-kit
Creator: Kenney (https://kenney.nl)
Licence: Creative Commons Zero (CC0). Original License.txt is included unchanged.
Suggested project credit: Vehicles and crash props by Kenney (CC0).
Models and texture files are unchanged from the publisher download. This package
adds only this instruction file and reorganises the FBX folder for easy import.
No scripts, package manifests, project settings, scenes or patient data are included.
The files have not been opened or tested in your Unity installation.
