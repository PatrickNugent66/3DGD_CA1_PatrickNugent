using UnityEngine;

/// <summary>
/// Spawns a random civilian type with a random destination every 20 seconds 
/// </summary>
public class SpawnCivilian : MonoBehaviour
{
    [SerializeField]
    private GameObject civilianPrefab1;

    [SerializeField]
    private GameObject civilianPrefab2;

    [SerializeField]
    private GameObject civilianPrefab3;

    [SerializeField]
    private GameObject civilianPrefab4;

    [SerializeField]
    private Transform[] destinationPoints;

    private GameObject civilianInstance1;
    private GameObject civilianInstance2;
    private GameObject civilianInstance3;
    private GameObject civilianInstance4;

    private void Start()
    {
        InvokeRepeating("Spawn", 5f, 20f);
    }

    private void Spawn()
    {
        //Choose a random number to determine which civilian type is spawned
        int civilianNumber = Random.Range(1, 4);

        GameObject civilianInstance;

        if(civilianNumber == 1)
        {
            civilianInstance = Instantiate(civilianPrefab1);
        }
        else if(civilianNumber == 2)
        {
            civilianInstance = Instantiate(civilianPrefab2);
        }
        else if(civilianNumber == 3)
        {
            civilianInstance = Instantiate(civilianPrefab3);
        }
        else
        {
            civilianInstance = Instantiate(civilianPrefab4);
        }

        //Choose a random number to determine which position to spawn the civilian
        int positionNumber = Random.Range(1, 4);

        if (positionNumber == 1)
        {
            civilianInstance.transform.position = new Vector3(124.9f, -0.2f, 88f);
            civilianInstance.transform.rotation = Quaternion.Euler(0, 180, 0);
            civilianInstance.GetComponent<CivilianBehaviour>().destinationPoint = destinationPoints[1];
        }
        else if (positionNumber == 2)
        {
            civilianInstance.transform.position = new Vector3(124.77f, -0.2f, 60.49f);
            civilianInstance.GetComponent<CivilianBehaviour>().destinationPoint = destinationPoints[0];
        }
        else if (positionNumber == 3)
        {
            civilianInstance.transform.position = new Vector3(117.83f, -0.2f, 88f);
            civilianInstance.transform.rotation = Quaternion.Euler(0, 180, 0);
            civilianInstance.GetComponent<CivilianBehaviour>().destinationPoint = destinationPoints[3];
        }
        else
        {
            civilianInstance.transform.position = new Vector3(118.14f, -0.2f, 60.49f);
            civilianInstance.GetComponent<CivilianBehaviour>().destinationPoint = destinationPoints[2];
        }

        civilianInstance.SetActive(true);
    }
}