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
    private GameObject InventoryMenu;

    void OnEnable()
    {
        MainUI.SetActive(true);
        InventoryMenu.SetActive(false);
    }
}