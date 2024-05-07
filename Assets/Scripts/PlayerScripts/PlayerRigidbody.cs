using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerRigidbody : MonoBehaviour
{
    public float velocidade = 5f;
    float velocidadePadrao;
    public static bool podeMover = true;
    private Rigidbody rb;
    private InputManager input;
    Vector3 movimento;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<InputManager>();
    }

    void Update()
    {
       if(podeMover == false)
       {
            return;
       }
    
        MovePlayer();
    }
    void MovePlayer()
    {
        movimento = new Vector3(input.Horizontal, 0f, input.Vertical) * velocidade * Time.deltaTime;   
        rb.MovePosition(rb.position + transform.TransformDirection(movimento));   
    }
    
}
    