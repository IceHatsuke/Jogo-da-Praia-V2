using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDeteccaoGlove : MonoBehaviour
{
    public Transform playerTransform; // Referência ao transform do jogador
    public float moveSpeed = 5f; // Velocidade de movimento dos itens de lixo

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lixo"))
        {
            MoveTowardPlayer(other.transform);
            GameObject.Find("===SystemGeneral===").transform.Find("Spawner").gameObject.GetComponent<SpawnColetavel>().LimiteSpawn();
        }
    }

    // Função para mover o objeto de lixo em direção ao jogador
    void MoveTowardPlayer(Transform objTransform)
    {
        // Calcula a direção para onde o jogador está
        Vector3 directionToPlayer = (playerTransform.position - objTransform.position).normalized;

        // Move o objeto de lixo na direção do jogador
        objTransform.position += directionToPlayer * moveSpeed * Time.deltaTime;
    }

}
