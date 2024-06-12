using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDeteccaoGlove : MonoBehaviour
{
    public Transform playerTransform; // Refer�ncia ao transform do jogador
    public float moveSpeed = 5f; // Velocidade de movimento dos itens de lixo

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lixo"))
        {
            MoveTowardPlayer(other.transform);
            GameObject.Find("===SystemGeneral===").transform.Find("Spawner").gameObject.GetComponent<SpawnColetavel>().LimiteSpawn();
        }
    }

    // Fun��o para mover o objeto de lixo em dire��o ao jogador
    void MoveTowardPlayer(Transform objTransform)
    {
        // Calcula a dire��o para onde o jogador est�
        Vector3 directionToPlayer = (playerTransform.position - objTransform.position).normalized;

        // Move o objeto de lixo na dire��o do jogador
        objTransform.position += directionToPlayer * moveSpeed * Time.deltaTime;
    }

}
