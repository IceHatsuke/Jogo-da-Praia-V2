using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject playerAlvo;

    public CharacterController cc;

    public float velocidade = 5f;

    //vida do Monstro
    public int vidaAtras;
    public int vidaFrente;

    RectTransform barraVidaAtras;
    RectTransform barraVidaFrente;
    Transform canvas;
    

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();

        vidaFrente = vidaAtras;

        barraVidaFrente = transform.Find("MonstroLixo").transform.Find("VidaInimigo").transform.Find("BarraVidaFrente").GetComponent<RectTransform>();
        barraVidaAtras = transform.Find("MonstroLixo").transform.Find("VidaInimigo").transform.Find("BarraVidaAtras").GetComponent<RectTransform>();
        canvas = transform.Find("MonstroLixo").transform.Find("VidaInimigo");
    }

    // Update is called once per frame
    void Update()
    {
        PegaAlvo();
        if(playerAlvo == null)
        {
            return;
        }

        Vector3 mover = (playerAlvo.transform.position - transform.position).normalized;
        mover *= Time.deltaTime * velocidade;
        cc.Move(mover);

    }


    public void PegaAlvo()
    {
        GameObject Alvo = GameObject.FindWithTag("Player");
    }

    void atualizarHUD()
    {
        // Calcular quanto deve ser reduzido de vida
        float reducao = (float)vidaAtras / (float)vidaFrente;
        reducao = reducao * 100;
        // Diminuir a barra de vida
        barraVidaFrente.sizeDelta = new Vector2(reducao, barraVidaFrente.sizeDelta.y );
        // Realocar a posicao X da barra de vida para a esquerda
        float posicao = (barraVidaAtras.sizeDelta.x - barraVidaAtras.sizeDelta.x) / 2;
        barraVidaAtras.anchoredPosition = new Vector2( posicao , barraVidaAtras.anchoredPosition.y );
    }

    public void receberDano(int valor)
    {
        vidaAtras -= valor;
        verificaMorte();
        atualizarHUD();
    }

    void verificaMorte()
    {
        if (vidaAtras <= 0)
        {
            Destroy(gameObject);
        }
    }

}
