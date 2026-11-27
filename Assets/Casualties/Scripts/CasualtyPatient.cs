using UnityEngine;

public class CasualtyPatient : MonoBehaviour
{
    // create where to upload patient data file
    public CasualtyData data;

    //Start checks. Each method is one check the trainee
    // can do in START order 

    // Step 1: Ask patient to walk
    [ContextMenu("1. Ask to walk")]
    public void AskToWalk()
    {
        if (data.canWalk)
            Debug.Log($"Case {data.caseNumber}: the patient stands up and walks.");
        else
            Debug.Log($"Case {data.caseNumber}: the patient cannot walk.");          
    }

    // Step 2: Look, listen and feel for breathing.
    [ContextMenu("2. Check breathing")]
    public void CheckBreathing()
    {
        if (data.isBreathing)
            Debug.Log($"Case {data.caseNumber}: the patient is breathing.");
        else
            Debug.Log($"Case {data.caseNumber}: the patient is NOT brething.");                
    }

    // Step 3: count breaths per minute.
    [ContextMenu("3. Count respiratory rate")]
    public void CountRespiratoryRate()
    {
        Debug.Log($"Case {data.caseNumber}: respiratory rate is {data.respiratoryRate}/min.");        
    }

    //Step 4: Radial pulse and capillary refill.
    [ContextMenu("4. Check perfusion")]
    public void CheckPerfusion()
    {
        string pulse = data.radialPulsePresent ? "present" : "absent";
        Debug.Log($"Case {data.caseNumber}: radial pulse {pulse}, capillary refill {data.capillaryRefillSeconds} s.");
    }

    //Step 5. give a simple command ("Squeeze my hand)
    [ContextMenu("5. Give command")]
    public void GiveCommand()
    {
        if (data.followsCommands)
            Debug.Log($"Case {data.caseNumber}: the patient squeezes your hand.");
        else
            Debug.Log($"Case {data.caseNumber}: the patient does not respond.");                
    }

}
