using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialText : MonoBehaviour {

  public GameObject tutorialText;

  private void Start()
  {
    tutorialText.SetActive(false);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      tutorialText.SetActive(true);
    }
  }
}
