using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

/// <summary>
/// Handles all pause menu logic for pausing and unpausing the game
/// </summary>
public class PauseGame : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if(Time.timeScale != 0)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void ReturnToMenu()
    {
        DialogueManager.ResetDatabase();

        QuestLog.SetQuestState("Question the locals", QuestState.Unassigned);

        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}