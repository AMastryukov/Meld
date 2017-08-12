using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWebsite : MonoBehaviour {

  private void OnMouseDown()
  {
    Application.OpenURL("https://amastryukov.itch.io/meld");
    GetComponent<Text>().text = "Thank you!";
  }
}
