using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enables and disables objects for the end phase
/// of the game
/// </summary>
public class LightsOut : MonoBehaviour
{
    [SerializeField]
    private GameObject lights;

    [SerializeField]
    private GameObject wall;

    [SerializeField]
    private GameObject horrorAmbience;

    [SerializeField]
    private GameObject ambience;

    void Start()
    {
        lights.SetActive(false);
        wall.SetActive(true);
        ambience.SetActive(false);
        horrorAmbience.SetActive(true);
    }
}
