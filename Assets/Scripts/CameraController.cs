using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

  public GameObject player;
  public int deadzone;

  private Vector3 offset;
  
	void Start () {

    offset = transform.position - player.transform.position;
	}
	
	void LateUpdate ()
  {
    // get mouse position
    Vector3 mousePosition = Input.mousePosition;
    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

    transform.position = player.transform.position + offset + 
      new Vector3(
        -(transform.position.x - mousePosition.x) / deadzone, 
        -(transform.position.y - mousePosition.y) / deadzone,
        0.0f);
	}
}
