using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeld : MonoBehaviour {

  public GameController gameController;
  public Sprite[] playerSprites;
  public GameObject light;

  bool meldMode = false;

  public float meldAmount = 1.0f;
  float meldDrainPerSecond = 0.25f;
  float meldGainPerSecond = 0.1f;
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown("space"))
    {
      if (!meldMode && meldAmount < 0.5f)
      {
        
      } else
      {
        meldMode = !meldMode;

        updateMeld();
        updateWalls();
      }
    }

    // handle meld draining/gaining
    if (meldMode)
    {
      meldAmount -= meldDrainPerSecond * Time.deltaTime;
    } else
    {
      meldAmount += meldGainPerSecond * Time.deltaTime;
    }

    if (meldAmount >= 1.0f) { meldAmount = 1.0f; }

    // exit meld mode if meld meter runs out
    if (meldAmount <= 0.0f)
    {
      meldAmount = 0.0f;
      meldMode = !meldMode;

      // update the meld status and walls
      updateMeld();
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

  void updateMeld()
  {
    // handle meld mode speed and sprite changes
    if (meldMode)
    {
      GetComponent<PlayerController>().speed = 10;
      GetComponent<SpriteRenderer>().sprite = playerSprites[1];
      light.GetComponent<Light>().intensity = 0.2f;
      light.GetComponent<Light>().spotAngle = 55;
    }
    else
    {
      GetComponent<PlayerController>().speed = 20;
      GetComponent<SpriteRenderer>().sprite = playerSprites[0];
      light.GetComponent<Light>().intensity = 1.25f;
      light.GetComponent<Light>().spotAngle = 110;
    }
  }
}
