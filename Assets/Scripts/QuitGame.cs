using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exits the application when the quit button is selected
/// </summary>
public class QuitGame : MonoBehaviour
{
    void Start()
    {
        Application.Quit();
    }
}
