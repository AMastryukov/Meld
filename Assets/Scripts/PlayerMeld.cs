using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeld : MonoBehaviour {

  public GameController gameController;
  bool meldMode = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown("space"))
    {
      meldMode = !meldMode;

      if (meldMode)
      {
        GetComponent<PlayerController>().speed = 10;
      } else
      {
        GetComponent<PlayerController>().speed = 25;
      }

      updateWalls();
    }
  }

  void updateWalls()
  {
    for (int i = 0; i < gameController.meldWalls.Length; i++)
    {
      gameController.meldWalls[i].GetComponent<BoxCollider2D>().isTrigger = meldMode;
    }
  }
}
