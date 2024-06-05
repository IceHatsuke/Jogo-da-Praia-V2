using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{

  public bool mobile = false;
  public GameObject monstroLixo;
  public static GameManager gameManager;
  public bool aspiradorHand;
  public bool armadilha;
  public int moeda = 0;
  public int score = 0;
  public int lixoColetado = 0;
  public bool glove = false;
  public GameObject hand;
  public TextMeshProUGUI lixoText;
  public TextMeshProUGUI moedaText;
  void Awake()
  {
    gameManager = GetComponent<GameManager>();
  }
  void Start()
  {
    aspiradorHand = false;
    armadilha = false;
  }
  void Update()
  {
    lixoText.text = lixoColetado.ToString();
    moedaText.text = moeda.ToString();
    
    // verificar possivel bug, matar monstro com quinze lixos
    if(lixoColetado == 15)
    {
     monstroLixo.SetActive(true);
    }
   
  }
  public void DisableHand()
  {
    hand.SetActive(false);
  }
}
