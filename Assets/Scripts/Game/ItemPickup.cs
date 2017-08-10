using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

  public GameObject player;
  public bool inInventory = false;

  private void OnMouseDown()
  {
    if (!inInventory)
    {
      player.GetComponent<PlayerInventory>().AddItem(gameObject);
      inInventory = !inInventory;
    }
    else if (!player.GetComponent<PlayerMeld>().meldMode)
    {
      player.GetComponent<PlayerInventory>().RemoveItem(gameObject);
      inInventory = !inInventory;
    }
  }
}
