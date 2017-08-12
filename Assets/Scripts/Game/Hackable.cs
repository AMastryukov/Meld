using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hackable : MonoBehaviour {

  public PlayerInventory inventory;
  public bool notDisabled = true;

  private void OnMouseDown()
  {
    int itemIndex = inventory.ReturnIndexWithName("item_hacktool");
    Debug.Log(itemIndex);

    // if the camera is working and the player has a hacktool
    if (notDisabled && (itemIndex != -1))
    {
      GameObject item = inventory.inventory[itemIndex];

      // remove the item from inventory then destroy it
      inventory.RemoveItemByIndex(itemIndex);
      Destroy(item);

      // disable the camera
      gameObject.GetComponent<EnemyDetection>().enabled = false;
      gameObject.GetComponentInChildren<Light>().enabled = false;

      notDisabled = false;
    }
  }
}
