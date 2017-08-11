using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

  public GameObject player;
  public bool inInventory = false;

  float distanceToPickup  = 1.0f;

  private void OnMouseDown()
  {
    if (!inInventory && Vector3.Distance(player.transform.position, transform.position) < distanceToPickup)
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
