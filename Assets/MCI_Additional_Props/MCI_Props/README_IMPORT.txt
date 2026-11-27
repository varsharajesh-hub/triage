MCI PROPS - GURNEY, BLANKET AND BUSHES

WHAT IS INCLUDED
Medical/Gurney_Transport.fbx : clean wheeled patient transport trolley.
Medical/Blanket_Throw.fbx : rust-coloured cloth/throw blanket, visual prop.
Nature/plant_bush*.fbx : six low-poly bush variants.
Medical textures and source/licence notes are included.
No scripts, XR settings, patient data, physics behaviour or scene files are added.

IMPORT IN UNITY
1. Extract the ZIP outside your Unity project.
2. Copy the entire MCI_Props folder into your Unity project's Assets folder.
   Alternatively drag MCI_Props into Assets in Unity's Project panel.
3. Keep the complete Medical folder, including Textures and the .fbm folders.
   These folders contain colour images referenced by the FBX material data.
4. Wait for the import to finish. Drag one FBX from Project into an empty area
   of the Hierarchy. Do not drag it inside a stretched pad or vehicle cube.
5. Start with Rotation (0,0,0) and Scale (1,1,1) for the medical props. Their
   pivots are centred at their base, so Position Y should match the surface top.
   Try Scale (3,3,3) for the bushes, whose original models are small.
6. Inspect one instance before duplicating it. Save your scene with Ctrl+S.

MEASURED MEDICAL DIMENSIONS AT SCALE 1
Gurney: X span 2.100 m, height 1.181 m, Z span 0.770 m.
Blanket: X span 1.350 m, height 0.197 m, Z span 1.751 m.
The blanket has a shallow draped shape. It does not simulate cloth and will not
fit itself over a patient. The gurney is a static prop, without grab/move logic.

IF A MATERIAL IS PINK OR GREY IN YOUR URP PROJECT
The files are standard FBX assets rather than a tested Unity URP package.
For a material that does not import correctly, select the FBX in Project, open
its Materials tab and use Extract Materials into a new folder. Use URP/Lit for
those extracted materials and assign the corresponding colour texture to Base
Map if needed. Match the existing material texture before changing the shader.
The bush colours are plain material colours rather than separate texture maps.
Do not alter your existing road or zone materials to recolour these props.

CHECKS PERFORMED
All eight FBX files were re-imported into Blender. Geometry and ground-level
pivots were checked, and the medical prop texture references loaded correctly.
The files have NOT been run in your Unity installation or tested on a headset.

PROJECT USE
Keep your current road, zones, vehicles and CAS_01-CAS_10 placement points.
The props are for environment dressing; patient implementation remains with
your classmates. Keep source/licence notes when committing the imported files.

CREDITS
Medical props: Innerscene (CC0), with GLB-to-FBX conversion and joined geometry.
Bushes: Kenney Nature Kit (CC0), with GLB-to-FBX conversion and joined geometry.
See the source/licence files in Medical and Nature for the original URLs.
