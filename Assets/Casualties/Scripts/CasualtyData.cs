// Grant acess to Unity's Features (ScriptableObject, Header, etc.)
using UnityEngine;

// "enum" fixed list of options
public enum TriageCategory { Green, Yellow, Red, Black }

// Adding triage to Project Window + Naming a new file and location
[CreateAssetMenu(fileName= "CasualtyData", menuName = "Triage/Casualty Data")]

// Defining new data file called casualty data 
public class CasualtyData : ScriptableObject
{
    // Case info
    [Header("Case info")]
    public int caseNumber;
    public string title;
    //fitting the text box
    [TextArea(3,6)] public string whatTraineeSees;
    
    //START triage findings + steps in order
    [Header("START Findings")]

    //Step 1: Can the person walk?
    public bool canWalk;

    //Step 2: Is the Patient breathing?
    public bool isBreathing;

    //Step 2b Only if not breathing. Breathes after opening the airway?
    public bool breathesAfterAirwayRepositioning;

    //Step 3: Breaths per minute. Over 30 + range and slider to stop weird values
    [Range(0,60)] public int respiratoryRate;

    //Step 3a: Can you feel a pulse at the wrist?
    public bool radialPulsePresent = true;

    //Step 4: Seconds for color to return after pressing the nail bed
    [Range(0f,6f)] public float capillaryRefillSeconds = 2f;

    //Step 5: Does the patient follow simple commands?
    public bool followsCommands;

    //Answer Key
    [Header("Answer key")]

    //The correct category for this patient. Trainees choice is compared to this
    public TriageCategory expectedCategory;

    // 3D PATIENT
    [Header("3D patient")]
    // The prefab the spawner will place in the scene for this casualty.
    public GameObject prefab;


}