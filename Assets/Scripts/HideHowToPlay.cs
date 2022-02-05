using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Hides the how to play menu
/// </summary>
public class HideHowToPlay : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;

    [SerializeField]
    private GameObject howToPlayText;

    void OnEnable()
    {
        mainMenu.SetActive(true);
        howToPlayText.SetActive(false);
    }
}