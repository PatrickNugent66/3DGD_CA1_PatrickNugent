using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CopDistracted : MonoBehaviour
{
    [SerializeField]
    private Transform destinationPoint;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = true;

        agent.destination = destinationPoint.position;
    }
}