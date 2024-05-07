using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
  public float Horizontal;
  public float Vertical;
  public bool Jump;

  void Update()
  {
    Horizontal = Input.GetAxis("Horizontal");
    Vertical = Input.GetAxis("Vertical");

    Jump = Input.GetKeyDown(KeyCode.Space);
  }

}
