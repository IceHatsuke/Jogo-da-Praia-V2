using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject playerAlvo;

    public CharacterController cc;

    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
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

}
