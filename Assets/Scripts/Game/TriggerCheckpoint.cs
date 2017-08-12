using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheckpoint : MonoBehaviour {

  public DoorControl door;
  public GameController gameController;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      gameController.startingPos = new Vector3(transform.position.x, transform.position.y, 1.5f);
      door.CloseDoor();
      GetComponent<BoxCollider2D>().enabled = false;
    }
  }
}
