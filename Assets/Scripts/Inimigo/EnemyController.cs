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

    private bool emEspera = false;
    

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PegaAlvo();
        if(playerAlvo == null || emEspera)
        {
            return;
        }

        Vector3 mover = (playerAlvo.transform.position - transform.position).normalized;
        mover.y = 0;
        mover *= Time.deltaTime * velocidade;
        cc.Move(mover);

        transform.rotation = Quaternion.LookRotation(mover);

        Vector3 fixedYPosition = transform.position;
        fixedYPosition.y = fixedPosition;
        transform.position = fixedYPosition;

    }


    public void PegaAlvo()
    {
        playerAlvo = GameObject.FindWithTag("Player").gameObject;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerRigidbody>().ReceberDano();

            StartCoroutine(EmEspera());

        }    
        
        if (other.CompareTag("Trap"))
        {
            Destroy(other.gameObject); 

            StartCoroutine(EmEsperaTrap());
        }
    }

    IEnumerator EmEspera()
    {
        emEspera = true;
        yield return new WaitForSeconds(1f);
        emEspera = false;

    }

    IEnumerator EmEsperaTrap()
    {
        emEspera = true;
        yield return new WaitForSeconds(5f);
        emEspera = false;
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
