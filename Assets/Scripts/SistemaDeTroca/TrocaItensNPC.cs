using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrocaItensNPC : MonoBehaviour
{

    

    public void TrocaLixoPor1Moeda()
    {

        if(GameManager.gameManager.lixoColetado != 0)
        {
            GameManager.gameManager.moeda++;

            GameManager.gameManager.lixoColetado -= 1; 
        }
    }
    public void Troca20MoedasPorAspirador()
    {
        if(GameManager.gameManager.moeda >= 20)
        {
            GameManager.gameManager.moeda -= 20;
            GameManager.gameManager.aspiradorHand = true;
        }
    }
    public void Trocar20MoedasPorLuva()
    {
        if(GameManager.gameManager.moeda >= 10)
        {
            GameManager.gameManager.moeda -= 10;
            GameManager.gameManager.glove = true;
        }
    }

    public void Trocar20MoedasPorArmadilha()
    {
        if(GameManager.gameManager.moeda >= 10)
        {
            GameManager.gameManager.moeda -= 10;
            GameManager.gameManager.armadilha = true;

            GameObject.Find("====HudInGame====").transform.Find("Drop Trap").gameObject.SetActive(true);
            DropObject.numTrap = 5;

        }
    }
}
