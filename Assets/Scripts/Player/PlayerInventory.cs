using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

  public GameObject[] inventory;
  public GameObject inventoryDisplay;

  public void AddItem(GameObject item)
  {
    bool dupe = false;

    // ensure no dupes exist
    for (int i = 0; i < inventory.Length; i++)
    {
      if (inventory[i] == item)
      {
        dupe = true;
        break;
      }
    }

    // put in the first empty slot
    for (int i = 0; i < inventory.Length; i++)
    {
      if (inventory[i] == null && !dupe) {
        inventory[i] = item;
        break;
      }
    }

    inventoryDisplay.GetComponent<InventoryDisplay>().updateItems(inventory);
  }

  // remove the item
  public void RemoveItem(GameObject item)
  {
    for (int i = 0; i < inventory.Length; i++)
    {
      if (inventory[i] == item)
      {
        inventoryDisplay.GetComponent<InventoryDisplay>().removeItem(inventory, i);
        inventory[i] = null;
      }
    }
  }
}
