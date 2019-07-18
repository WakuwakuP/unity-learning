using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
  float rotateSpeed = 0;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButton(0))
    {
      this.rotateSpeed = 10;
    }

    transform.Rotate(0, 0, this.rotateSpeed);

    this.SetNewRotateSpeed();
  }

  void SetNewRotateSpeed()
  {
    this.rotateSpeed *= 0.96f;
  }
}
