using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

  public Grid grid;

	// Use this for initialization
	void Start () {
    grid.InitializeGrid(2, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
