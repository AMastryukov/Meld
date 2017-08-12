using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour {

  public string tileType;
  private bool isWall;
  private bool isMeldable;

  void Start()
  {
    switch(tileType)
    {
      case "floor":
        GetComponent<BoxCollider2D>().enabled = false;
        transform.Rotate(new Vector3(0,0,90 * Random.Range(1,4)));
        break;
    }
  }

  public bool IsWall
  {
    get
    {
      return isWall;
    }
    set
    {
      isWall = value;
    }
  }
  public bool IsMeldable
  {
    get
    {
      return isMeldable;
    }
    set
    {
      isMeldable = value;
    }
  }
}
