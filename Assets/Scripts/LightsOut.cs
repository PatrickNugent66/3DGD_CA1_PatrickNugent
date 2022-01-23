using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour
{
    [SerializeField]
    private GameObject lights;

    [SerializeField]
    private GameObject wall;

    void Start()
    {
        lights.SetActive(false);
        wall.SetActive(true);
    }
}
