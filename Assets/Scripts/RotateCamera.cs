using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotates the camera around the player when the A or D
/// keys are pressed
/// </summary>
public class RotateCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {

            transform.RotateAround(player.transform.position, Vector3.up, 90 * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(player.transform.position, Vector3.down, 90 * Time.deltaTime);
        }
    }
}