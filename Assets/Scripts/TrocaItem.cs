using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class TrocaItem : MonoBehaviour
{

    public GameObject spriteMao;
    public GameObject spriteGlove;

    public GameObject spriteAspirador;

    private bool spriteTrocado = false;

    void Update()
    {
        if(UnityEngine.Input.GetMouseButtonDown(1) && GameManager.gameManager.aspiradorHand == true)
        {
            spriteTrocado = !spriteTrocado;

        if(GameManager.gameManager.glove == true )
        {
            spriteGlove.SetActive(!spriteTrocado);
        }
        
        }

        spriteMao.SetActive(!spriteTrocado);
          
       
        spriteAspirador.SetActive(spriteTrocado);
        
    }
}
