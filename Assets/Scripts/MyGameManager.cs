using GD.Managers;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

namespace MyGame
{
    /// <summary>
    /// GameManager class that starts and ends the game
    /// </summary>
    public class MyGameManager : GameManager
    {
        private void Start()
        {
            //instanciate the waits used by start, play, or end functions
            InitializeWaits();

            //start the main loop that will perform start/end actions and check win/lose logic
            StartCoroutine(GameLoop());
        }

        protected override IEnumerator StartLevel()
        {
            SceneManager.UnloadSceneAsync("Menu");
            SceneManager.LoadScene("Street", LoadSceneMode.Additive);
            SceneManager.LoadScene("Apartment", LoadSceneMode.Additive);
            SceneManager.LoadScene("Shotengai", LoadSceneMode.Additive);

            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Managers"));

            QuestLog.SetQuestState("Question the locals", QuestState.Active);

            yield return startWait;  //Timer
        }

        protected override void ShowStartToast()
        {
            //Debug.Log($"ShowStartToast at {Time.realtimeSinceStartup}");
        }

        protected override void CheckWinLose()
        {
            //Debug.Log($"CheckWinLose at {Time.realtimeSinceStartup}");
        }

        protected override void ShowWinLoseToast()
        {
            //Debug.Log($"ShowWinLoseToast at {Time.realtimeSinceStartup}");
        }

        public override IEnumerator EndLevel()
        {
            //ShowWinLoseToast();   //e.g. "You won!"

            //wait for N seconds to show the toast
            yield return endWait; //Timer

            //raise an event to show the main menu e.g. Event: MainMenu - Show
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
}