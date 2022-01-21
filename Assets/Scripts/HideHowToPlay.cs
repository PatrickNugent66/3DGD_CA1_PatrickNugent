using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Hides the how to play menu
/// </summary>
public class HideHowToPlay : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenu;

    [SerializeField]
    private GameObject HowToPlayText;

    void OnEnable()
    {
        MainMenu.SetActive(true);
        HowToPlayText.SetActive(false);
    }
}