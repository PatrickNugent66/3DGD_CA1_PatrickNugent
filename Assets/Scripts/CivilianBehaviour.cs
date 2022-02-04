using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Moves a civilian character to a certain point
/// </summary>
public class CivilianBehaviour : MonoBehaviour
{
    [SerializeField]
    public Transform destinationPoint;

    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = destinationPoint.position;

        //Destroy the civilian object after a certain amount of time
        Destroy(gameObject, 20);
    }
}
