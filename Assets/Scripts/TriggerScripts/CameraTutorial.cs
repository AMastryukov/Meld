﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTutorial : MonoBehaviour {

  public GameObject controlTutorial;
  public GameObject cameraTutorial;

  private void Start()
  {
    cameraTutorial.SetActive(false);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      cameraTutorial.SetActive(true);
    }
  }
}
