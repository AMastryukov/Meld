using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCamRotate : MonoBehaviour {
  
  public int rotationSpeed;
  public int rotationMax;

  float startingRotation;
  float totalRotation;

  private void Start()
  {
    startingRotation = transform.rotation.z;
    totalRotation = rotationMax / 2;
  }
  
  void Update () {
    transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    totalRotation += rotationSpeed * Time.deltaTime;

    if (Mathf.Abs(totalRotation) >= rotationMax && rotationMax != -1)
    {
      rotationSpeed = -rotationSpeed;
      totalRotation = 0;
    }
  }
}
