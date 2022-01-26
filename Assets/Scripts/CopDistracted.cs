using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Moves the cop NPC along a path to carry out the
/// distraction scenario
/// </summary>
public class CopDistracted : MonoBehaviour
{
    [SerializeField]
    private Transform destinationPoint;

    private NavMeshAgent agent;

    private Animator anim;

    private bool finished = false;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = true;

        anim.SetBool("IsWalking", true);

        agent.destination = destinationPoint.position;
    }

    void Update()
    {
        if (agent.remainingDistance < 0.1f && !finished)
        {
            finished = true;
            anim.SetBool("IsWalking", false);
        }
    }
}