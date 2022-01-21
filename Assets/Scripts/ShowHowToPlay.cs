using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shows the how to play menu
/// </summary>
public class ShowHowToPlay : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenu;

    [SerializeField]
    private GameObject HowToPlayText;

    void OnEnable()
    {
        MainMenu.SetActive(false);
        HowToPlayText.SetActive(true);
    }
}