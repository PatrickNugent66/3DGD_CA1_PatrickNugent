using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destroy the GameObject that this script is attached to
//when this script is enabled.
public class SelfDestruct : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject);
    }
}
