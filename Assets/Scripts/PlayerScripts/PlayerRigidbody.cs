using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerRigidbody : MonoBehaviour
{
    public bool mobile = false;
    public float velocidade = 5f;
    float velocidadePadrao;
    public static bool podeMover = true;
    private Rigidbody rb;
    private InputManager input;
    Vector3 movimento;

    public GameObject joystickUI;
    public VariableJoystick variableJoystick; //variavel joystick
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<InputManager>();
        
        joystickUI.SetActive(mobile);
    }

    void Update()
    {
        joystickUI.SetActive(mobile);


       if(podeMover == false)
       {
            return;
       }
       
        MovePlayer();
    }
    void MovePlayer()
    {
        if(mobile)
        {
            movimento = new Vector3(variableJoystick.Horizontal, 0f, variableJoystick.Vertical) * velocidade * Time.deltaTime;   
        }
        else
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            movimento = new Vector3(moveHorizontal, 0f, moveVertical) * velocidade * Time.deltaTime;
        }

        rb.MovePosition(rb.position + transform.TransformDirection(movimento));   
    }
    
}
    