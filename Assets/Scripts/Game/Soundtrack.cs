using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soundtrack : MonoBehaviour {

  public Slider volumeSlider;

  private void Start()
  {
    volumeSlider.value = GetComponent<AudioSource>().volume;
  }

  public void UpdateVolume()
  {
    GetComponent<AudioSource>().volume = volumeSlider.value;
  }
}
