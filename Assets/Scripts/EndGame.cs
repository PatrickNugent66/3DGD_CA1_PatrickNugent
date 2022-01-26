using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GD.Managers;

/// <summary>
/// Handles the ending scene and ends the game
/// </summary>
public class EndGame : MonoBehaviour
{
    [SerializeField]
    private GameObject OniMask;

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject EndingCamera;

    [SerializeField]
    private GameObject GameManager;

    void Start()
    {
        OniMask.SetActive(true);
        Player.SetActive(false);
        EndingCamera.SetActive(true);

        StartCoroutine(GameManager.GetComponent<MyGame.MyGameManager>().EndLevel());
    }
}
