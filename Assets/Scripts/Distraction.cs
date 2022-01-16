using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction : MonoBehaviour
{
    [SerializeField]
    private Transform[] destinationPoints;

    private int currentPoint = 0;

    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.autoBraking = true;

        HandleMovement();
    }

    void Update()
    {
        if (agent.remainingDistance < 0.1f)
        {
            HandleMovement();
        }
    }

    void HandleMovement()
    {
        if (destinationPoints.Length != currentPoint)
        {
            currentPoint++;
            agent.destination = destinationPoints[currentPoint].position;
        }
    }
}
