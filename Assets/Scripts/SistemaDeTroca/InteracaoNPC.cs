using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoNPC : MonoBehaviour
{
    public GameObject canvasTroca;
    public GameObject player;
    public GameObject glove;
    
    public Animator animator;


    private void Start()
    {
        player = GameObject.Find("Player");
        // Desativa o canvas no início para garantir que não esteja visível inicialmente
        if (canvasTroca != null)
        {
            canvasTroca.SetActive(false);
        }
        
    }



    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o personagem entrou na área de interação com o NPC
        if (other.CompareTag("Player"))
        {
            // Ativa o canvas de troca
            if (canvasTroca != null)
            {
                canvasTroca.SetActive(true);
                PlayerRigidbody.podeMover = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Verifica se o personagem saiu da área de interação com o NPC
        if (other.CompareTag("Player"))
        {
            // Desativa o canvas de troca
            if (canvasTroca != null)
            {
                canvasTroca.SetActive(false);
                animator.SetBool("glove", GameManager.gameManager.glove);
            }
        }
    }
}

