using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTileMeld : MonoBehaviour {

  public GameObject player;

  private void OnTriggerStay2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      player.GetComponent<PlayerMeld>().insideWall = true;
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      Debug.Log("FALSE");
      player.GetComponent<PlayerMeld>().insideWall = false;
    }
  }
}
