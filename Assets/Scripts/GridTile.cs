using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour {

  private int tileID;
  private bool isWall;
  private bool isMeldable;

  SpriteRenderer spriteRenderer;

  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

  public int TileID
  {
    get
    {
      return tileID;
    }
    set
    {
      tileID = value;
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
