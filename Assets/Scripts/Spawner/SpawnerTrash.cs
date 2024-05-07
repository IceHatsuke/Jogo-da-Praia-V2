using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColetavel : MonoBehaviour
{
    public Transform prefabColetavel;
    public Transform spawnColetavel;
    public float spawnInterval = 5f;

    void Start()
    {
        // Chame a função SpawnarLixo repetidamente com o intervalo especificado
        InvokeRepeating("SpawnarLixo", 0f, spawnInterval);
    }

    public void SpawnarLixo() 
    {
        // Calcular a área de spawn
        float areaX = spawnColetavel.localScale.x / 2;
        float areaZ = spawnColetavel.localScale.z / 2;

        // Gerar coordenadas aleatórias dentro da área de spawn
        float randomX = Random.Range(-areaX, areaX);
        float randomZ = Random.Range(-areaZ, areaZ);

        // Posição de spawn baseada nas coordenadas aleatórias
        Vector3 localSpawn = new Vector3(randomX, 1f, randomZ);

        // Instanciar o coletável na posição de spawn
        Instantiate(prefabColetavel, spawnColetavel.position + localSpawn, Quaternion.identity);
    }
}