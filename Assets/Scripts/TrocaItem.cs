using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UI;

public class TrocaItem : MonoBehaviour
{
    
    public GameObject aspiradorIcone;
    public GameObject maoIcone;

    public GameObject spriteMao;
    public GameObject spriteGlove;

    public GameObject spriteAspirador;

    public GameObject spriteNormal;
    public GameObject spriteTroca;
    
    private bool spriteTrocado = false;
    private bool primeiroAtivo = true;
    

    private SpriteRenderer spriteRenderer;

    public Button botaoTrocar;

    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = spriteNormal;
        botaoTrocar.onClick.AddListener(OnClick);
    }

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

    void OnClick()
    {
        if (UnityEngine.Input.GetMouseButtonDown(1))
        {
            if (spriteTrocado)
            {
                spriteRenderer.sprite = spriteNormal;
                spriteTrocado = false;
            }
            else
            {
                spriteRenderer.sprite = spriteTroca;
                spriteTrocado = true;

            }

            if (spriteTrocado)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("OutroSprite").GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("OutroSprite").GetComponent<SpriteRenderer>().enabled = true;
            }
        }
    }
    public void TrocarObjetos()
    {
        primeiroAtivo = !primeiroAtivo; // Inverte o estado atual

        // Troca o primeiro par de objetos
        maoIcone.SetActive(primeiroAtivo);
        spriteNormal.SetActive(primeiroAtivo);
        
        if(GameManager.gameManager.aspiradorHand == true)
        {
        aspiradorIcone.SetActive(!primeiroAtivo);
        aspirador.SetActive(!primeiroAtivo);
        }
        // Troca o segundo par de objetos
       
    }
}
