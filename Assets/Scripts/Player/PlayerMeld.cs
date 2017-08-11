using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeld : MonoBehaviour {

  public GameController gameController;
  public Sprite[] playerSprites;
  public GameObject lightObject;
  public float meldAmount = 1.0f;
  public bool insideWall = false;

  public bool meldMode = false;

  public float meldDrainPerSecond = 0.25f;
  public float meldGainPerSecond = 0.1f;
  public float meldCastThreshold = 0.25f;

  Vector3 meldStartPos;
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown("space"))
    {
      if (!meldMode && meldAmount < meldCastThreshold)
      {
        
      } else if (!insideWall)
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

    // exit meld mode if meld meter runs out and teleport player back to the starting point
    if (meldAmount <= 0.0f)
    {
      meldAmount = 0.0f;
      insideWall = false;
      meldMode = !meldMode;

      // teleport player back
      transform.position = meldStartPos;

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
      meldStartPos = transform.position;

      GetComponent<PlayerController>().speed = 12;
      GetComponent<SpriteRenderer>().sprite = playerSprites[1];
      lightObject.GetComponent<Light>().intensity = 0.3f;
      lightObject.GetComponent<Light>().spotAngle = 50;
    }
    else
    {
      GetComponent<PlayerController>().speed = 23;
      GetComponent<SpriteRenderer>().sprite = playerSprites[0];
      lightObject.GetComponent<Light>().intensity = 1.0f;
      lightObject.GetComponent<Light>().spotAngle = 110;
    }
  }
}
