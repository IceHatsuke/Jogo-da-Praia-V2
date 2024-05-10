using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager;
  public bool aspiradorHand;
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
  }
  void Update()
  {
    lixoText.text = lixoColetado.ToString();
    moedaText.text = moeda.ToString();
   
   
  }
  public void DisableHand()
  {
    hand.SetActive(false);
  }
}
