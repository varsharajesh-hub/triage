
using UnityEngine;

// Goes on ONE empty object in the scene. When the scene starts, it places every
// casualty from the scenario on its matching spawn point (Case 10 → CAS_10).
public class CasualtySpawner : MonoBehaviour
{
    public ScenarioData scenario;

    public Transform spawnPoints;

    void Start()
    {
        // "foreach" repeats the code inside { } once for every casualty in the list.
        // Each time, "data" is the current casualty.
        foreach (CasualtyData data in scenario.casualties)
        {
            // Build the spawn point name from the case number.
            // ToString("00") always uses 2 digits: 10 → "10", 3 → "03". So we get "CAS_10", "CAS_03".
            string pointName = "CAS_" + data.caseNumber.ToString("00");

            Transform point = spawnPoints.Find(pointName);

            // Safety checks: if something is missing, print a yellow warning in the Console
            // and "continue" = skip to the next casualty instead of crashing.
            if (point == null)
            {
                Debug.LogWarning($"No spawn point called {pointName} for case {data.caseNumber}.");
                continue;
            }
            if (data.prefab == null)
            {
                Debug.LogWarning($"Case {data.caseNumber} has no prefab set in its data file.");
                continue;
            }

            // The spawn points float a bit above the road (Y = 0.45).
            // A "raycast" shoots an invisible line straight down from the point;
            // if it hits something (the road/grass), we use that spot instead.
            Vector3 position = point.position;
            if (Physics.Raycast(point.position, Vector3.down, out RaycastHit hit, 5f))
                position = hit.point;

            GameObject patient = Instantiate(data.prefab, position, point.rotation, transform);
                        // Print a message so we can SEE in the Console that the spawn happened, and where.
            Debug.Log($"Spawned case {data.caseNumber} at {pointName}, position {position}.");

            // Hand the patient its data file. This means the SAME prefab could be reused
            // for a different case just by giving it different data.
            CasualtyPatient casualty = patient.GetComponent<CasualtyPatient>();
            if (casualty != null)
                casualty.data = data;
        }
    }
}








