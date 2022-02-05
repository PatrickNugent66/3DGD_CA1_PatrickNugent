using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Shows starting text and opens the managers scene 20
/// seconds after the play button is selected
/// </summary>
public class StartGame : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;

    [SerializeField]
    private GameObject introText;

    void Start()
    {
        mainMenu.SetActive(false);
        introText.SetActive(true);
        StartCoroutine(OpenLevel());
    }

    protected IEnumerator OpenLevel()
    {
        yield return new WaitForSeconds(20f);
        SceneManager.LoadScene("Managers", LoadSceneMode.Additive);
    }
}