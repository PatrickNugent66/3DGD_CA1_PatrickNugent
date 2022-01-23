using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shows the player's inventory
/// </summary>
public class ShowInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject MainUI;

    [SerializeField]
    private GameObject Inventory;

    void OnEnable()
    {
        MainUI.SetActive(false);
        Inventory.SetActive(true);
    }
}