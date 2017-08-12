using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour {

  public GameObject leftDoor;
  public GameObject rightDoor;
  public PlayerInventory inventory;
  public bool opened = false;
  public string itemName;

  private void OnMouseDown()
  {
    int itemIndex = inventory.ReturnIndexWithName(itemName);
    
    if (!opened && (itemIndex != -1))
    {
      OpenDoor();
    }
  }

  private void OpenDoor()
  {
    leftDoor.transform.position = 
      new Vector3(leftDoor.transform.position.x - 0.25f, leftDoor.transform.position.y, leftDoor.transform.position.z);
    rightDoor.transform.position = 
      new Vector3(rightDoor.transform.position.x + 0.25f, rightDoor.transform.position.y, rightDoor.transform.position.z);

    // disable the main collider and enable the two door colliders
    GetComponent<BoxCollider2D>().enabled = false;

    leftDoor.GetComponent<BoxCollider2D>().enabled = true;
    rightDoor.GetComponent<BoxCollider2D>().enabled = true;
  }
}
