using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GD.ScriptableTypes;
using GD.Events;

/// <summary>
/// Shows the player's inventory and determines which pickups
/// should be shown on the menu
/// </summary>
public class ShowInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject MainUI;

    [SerializeField]
    private GameObject InventoryMenu;

    [SerializeField]
    private GameObject InventoryManager;

    [SerializeField]
    private GameObject Radio;

    [SerializeField]
    private GameObject Money;

    [SerializeField]
    private GameObject Backpack;

    [SerializeField]
    private GameObject Crowbar;

    [SerializeField]
    private GameObject Sushi;

    [SerializeField]
    private GameObject Ramen;

    void OnEnable()
    {
        MainUI.SetActive(false);
        InventoryMenu.SetActive(true);

        //Get the list of pickups from the inventory manager
        List<PickupData> pickups = InventoryManager.GetComponent<InventoryManager>().pickups;

        //Initially set all item icons to not show
        Backpack.SetActive(false);
        Money.SetActive(false);
        Radio.SetActive(false);
        Crowbar.SetActive(false);
        Sushi.SetActive(false);
        Ramen.SetActive(false);

        if (pickups.Count > 0)
        {
            //Search the list of pickups and set the corresponding item
            //icon to active if it is found in the list
            for (int i = 0; i < pickups.Count; i++)
            {
                if (pickups[i].name == "money")
                {
                    Money.SetActive(true);
                }
                else if (pickups[i].name == "backpack")
                {
                    Backpack.SetActive(true);
                }
                else if (pickups[i].name == "radio")
                {
                    Radio.SetActive(true);
                }
                else if (pickups[i].name == "crowbar")
                {
                    Crowbar.SetActive(true);
                }
                else if (pickups[i].name == "sushi")
                {
                    Sushi.SetActive(true);
                }
                else if (pickups[i].name == "ramen")
                {
                    Ramen.SetActive(true);
                }
            }
        }

    }
}