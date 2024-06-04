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
    private GameObject gameOver;
    public int vida = 2;
    private InputManager input;
    Vector3 movimento;

    //public GameObject joystickUI;
    public VariableJoystick variableJoystick; //variavel joystick
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<InputManager>();
        
        //joystickUI.SetActive(GameManager.gameManager.mobile);
    }

    void Update()
    {
        //joystickUI.SetActive(GameManager.gameManager.mobile);


       if(podeMover == false)
       {
            return;
       }
       
        MovePlayer();
    }
    void MovePlayer()
    {
        if(GameManager.gameManager.mobile)
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
    
    public void ReceberDano()
    {
        vida--;
        GameObject.Find("====HudInGame====").transform.Find("Vida").Find("VidaText").GetComponent<TextMeshProUGUI>().text = "Vida:" + vida;

        if(vida <= 0) // Verifica se a vida é menor ou igual a 0
    {
        GameObject.Find("====HudInGame====").transform.Find("GameOver").gameObject.SetActive(true); // Ativa o canvas de Game Over
        Destroy(gameObject); // Destroi o objeto do jogador
    }
    }

}
    