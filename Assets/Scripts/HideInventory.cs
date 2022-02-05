using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Hides the player's inventory
/// </summary>
public class HideInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject mainUI;

    [SerializeField]
    private GameObject inventoryMenu;

    void OnEnable()
    {
        mainUI.SetActive(true);
        inventoryMenu.SetActive(false);
    }
}