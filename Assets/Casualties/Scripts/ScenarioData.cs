

// use List<>, a list that can grow and shrink.
using System.Collections.Generic;
using UnityEngine;

// Adds "Triage > Scenario Data" to the Create menu, like CasualtyData.
[CreateAssetMenu(fileName = "ScenarioData", menuName = "Triage/Scenario Data")]

// data file describing one whole scenario: which casualties are in it.
public class ScenarioData : ScriptableObject
{
    // A name for the scenario
    public string scenarioName;

    // In the Inspector this shows as a list with + and - buttons.
    public List<CasualtyData> casualties = new List<CasualtyData>();
}





