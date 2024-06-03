using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator animator;
    public GameObject playerAlvo;

    public CharacterController cc;

    public float velocidade = 3f;
    public float fixedPosition = 0;

    
    //public int vidaAtras;
    //public int vidaFrente;

    //RectTransform barraVidaAtras;
    //RectTransform barraVidaFrente;
    //Transform canvas;
    

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        //vidaFrente = vidaAtras;

        //barraVidaFrente = transform.Find("MonstroLixo").transform.Find("VidaInimigo").transform.Find("BarraVidaFrente").GetComponent<RectTransform>();
        //barraVidaAtras = transform.Find("MonstroLixo").transform.Find("VidaInimigo").transform.Find("BarraVidaAtras").GetComponent<RectTransform>();
        //canvas = transform.Find("MonstroLixo").transform.Find("VidaInimigo");
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
        mover.y = 0;
        mover *= Time.deltaTime * velocidade;
        cc.Move(mover);

         Vector3 fixedYPosition = transform.position;
        fixedYPosition.y = fixedPosition;
        transform.position = fixedYPosition;

    }


    public void PegaAlvo()
    {
        GameObject Alvo = GameObject.FindWithTag("Player");
    }

    //void atualizarHUD()
    
        // Calcular quanto deve ser reduzido de vida
        //float reducao = (float)vidaAtras / (float)vidaFrente;
        //reducao = reducao * 100;
        // Diminuir a barra de vida
        //barraVidaFrente.sizeDelta = new Vector2(reducao, barraVidaFrente.sizeDelta.y );
        // Realocar a posicao X da barra de vida para a esquerda
        //float posicao = (barraVidaAtras.sizeDelta.x - barraVidaAtras.sizeDelta.x) / 2;
        //barraVidaAtras.anchoredPosition = new Vector2( posicao , barraVidaAtras.anchoredPosition.y );
    

    

    

}
