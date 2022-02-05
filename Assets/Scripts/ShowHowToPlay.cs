using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shows the how to play menu
/// </summary>
public class ShowHowToPlay : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;

    [SerializeField]
    private GameObject howToPlayText;

    void OnEnable()
    {
        mainMenu.SetActive(false);
        howToPlayText.SetActive(true);
    }
}