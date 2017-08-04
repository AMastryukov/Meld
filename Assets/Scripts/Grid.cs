using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

  public Sprite[] tileSprites;
  public GameObject prefabTile;
  public GameObject[,] grid;

  // initialize a grid full of tiles based on dimensions
  public void InitializeGrid(int x, int y)
  {
    grid = new GameObject[x, y];

    for (int i = 0; i < x; i++)
    {
      for (int j = 0; j < y; j++)
      {
        grid[i, j] = (GameObject)Instantiate(prefabTile, new Vector3(j,-i), Quaternion.identity);
        grid[i, j].name = "Tile [" + i + "," + j + "]";
        grid[i, j].transform.parent = gameObject.transform;
      }
    }
  }
}
