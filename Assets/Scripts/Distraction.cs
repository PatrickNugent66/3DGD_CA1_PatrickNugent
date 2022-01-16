using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class Distraction : MonoBehaviour
{
    [SerializeField]
    private Transform[] destinationPoints;

    [SerializeField]
    private GameObject cop;

    private Animator anim;

    private int currentPoint = 0;

    private UnityEngine.AI.NavMeshAgent agent;

    private bool finished = false;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.autoBraking = true;

        //Remove Usable components from both characters to prevent further dialogue
        this.GetComponent<Usable>().enabled = false;
        cop.GetComponent<Usable>().enabled = false;

        anim.SetBool("IsWalking", true);

        HandleMovement();
    }

    void Update()
    {
        //If the character is near the next point and not finished then handle movement
        if (agent.remainingDistance < 0.1f && !finished)
        {
            HandleMovement();
        }
    }

    void HandleMovement()
    {
        //If the character is at the last point then able the cop's script, otherwise set
        //the current point index to the next point.
        if (currentPoint != destinationPoints.Length)
        {
            agent.destination = destinationPoints[currentPoint].position;
            currentPoint++;
        }
        else
        {
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsKicking", true);
            finished = true;
            cop.GetComponent<CopDistracted>().enabled = true;
        }
    }
}
