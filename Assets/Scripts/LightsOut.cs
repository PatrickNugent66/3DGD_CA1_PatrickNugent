using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour
{
    private GameObject lights;

    [SerializeField]
    private GameObject wall;

    void Start()
    {
        lights = GameObject.Find("/Shotengai/Lights");
        lights.SetActive(false);
        wall.SetActive(true);
    }
}
