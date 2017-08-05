using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

  public float speed;

  private Rigidbody2D rigidBody;
  
	void Start () {
    rigidBody = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    Vector2 movement = new Vector2(moveX, moveY);

    rigidBody.AddForce(movement * speed);
	}
}
