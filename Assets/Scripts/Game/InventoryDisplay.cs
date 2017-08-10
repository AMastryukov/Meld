using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour {

  public GameObject[] slots;
  public Material diffuseSprite;
  public Material defaultSprite;
  public GameObject itemField;
  public GameObject player;

  public void updateItems(GameObject[] inventory)
  {
    for (int i = 0; i < inventory.Length; i++)
    {
      if (inventory[i] != null)
      {
        // attach the item to the inventory display
        inventory[i].transform.position = slots[i].transform.position;
        inventory[i].transform.SetParent(slots[i].transform);

        inventory[i].GetComponent<SpriteRenderer>().material = defaultSprite;
      }
    }
  }

  public void removeItem(GameObject[] inventory, int index)
  {
    inventory[index].transform.position = 
      new Vector3(player.transform.position.x, player.transform.position.y, itemField.transform.position.z);
    inventory[index].transform.SetParent(itemField.transform);

    inventory[index].GetComponent<SpriteRenderer>().material = diffuseSprite;
  }
}
