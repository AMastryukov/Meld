using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeldTutorial : MonoBehaviour {
  
  public GameObject meldTutorial;

  private void Start()
  {
    meldTutorial.SetActive(false);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      meldTutorial.SetActive(true);
    }
  }
}
