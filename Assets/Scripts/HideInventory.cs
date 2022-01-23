using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Hides the player's inventory
/// </summary>
public class HideInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject MainUI;

    [SerializeField]
    private GameObject Inventory;

    void OnEnable()
    {
        MainUI.SetActive(true);
        Inventory.SetActive(false);
    }
}