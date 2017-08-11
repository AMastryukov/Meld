using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour {

  public GameController gameController;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    // detect player collision and ensure the camera isnt disabled
    if (collision.gameObject.tag == "Player" && 
      gameObject.GetComponent<Hackable>().notDisabled)
    {
      collision.gameObject.transform.position = gameController.startingPos;
    }
  }
}
