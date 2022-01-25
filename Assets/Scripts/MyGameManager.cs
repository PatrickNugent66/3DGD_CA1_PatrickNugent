using GD.Managers;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("Apartment", LoadSceneMode.Additive);
            SceneManager.LoadScene("Street", LoadSceneMode.Additive);
            SceneManager.LoadScene("Shotengai", LoadSceneMode.Additive);

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

        protected override IEnumerator EndLevel()
        {
            ShowWinLoseToast();   //e.g. "You won!"

            //wait for N seconds to show the toast
            yield return endWait; //Timer

            //raise an event to show the main menu e.g. Event: MainMenu - Show
            
        }
    }
}