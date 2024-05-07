using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager gameManager;
  public bool aspiradorHand;
  public int moeda = 0;
  public int score = 0;
  public int lixoColetado = 0;
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
}
