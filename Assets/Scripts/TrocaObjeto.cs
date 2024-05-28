using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaObjeto : MonoBehaviour
{   
    public GameObject maoIcone;
    public GameObject aspiradorIcone;
    public GameObject mao;
    public GameObject aspirador;

    private bool primeiroAtivo = true;
    void Start()
    {
        primeiroAtivo = true;
    }

    public void TrocarObjetos()
    {
        primeiroAtivo = !primeiroAtivo; // Inverte o estado atual

        // Troca o primeiro par de objetos
        maoIcone.SetActive(primeiroAtivo);
        mao.SetActive(primeiroAtivo);
        Debug.Log("sdfsfd");
        

        // Troca o segundo par de objetos
        aspiradorIcone.SetActive(!primeiroAtivo);
        aspirador.SetActive(!primeiroAtivo);
    }
}
