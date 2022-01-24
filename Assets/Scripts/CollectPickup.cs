using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Calls the pickup behaviour script to collect the pickup
/// that this script is attached to
/// </summary>
public class CollectPickup : MonoBehaviour
{
    void Start()
    {
        GameObject player = GameObject.Find("Ren");
        PlayerPickupBehaviour pickupBehaviour = player.GetComponent<PlayerPickupBehaviour>();
        pickupBehaviour.CollectPickup(this.gameObject);
    }
}