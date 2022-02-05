using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GD.Managers;
using PixelCrushers.DialogueSystem;

/// <summary>
/// Handles the ending scene and ends the game
/// </summary>
public class EndGame : MonoBehaviour
{
    [SerializeField]
    private GameObject oniMask;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject screamSound;

    [SerializeField]
    private GameObject endingCamera;

    void Start()
    {
        oniMask.SetActive(true);
        player.SetActive(false);
        screamSound.SetActive(true);
        endingCamera.SetActive(true);

        DialogueManager.ResetDatabase();

        QuestLog.SetQuestState("Question the locals", QuestState.Unassigned);

        StartCoroutine(this.GetComponent<MyGame.MyGameManager>().EndLevel());
    }
}
