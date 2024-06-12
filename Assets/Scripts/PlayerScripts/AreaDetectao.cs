using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetectao : MonoBehaviour
{
   void OnTriggerEnter(Collider collider)
   {
        if(collider.CompareTag("Lixo"))
        {
            collider.GetComponent<ObjectsStatus>().DestroyObject();
            GameManager.gameManager.lixoColetado++;
            GameObject.Find("===SystemGeneral===").transform.Find("Spawner").gameObject.GetComponent<SpawnColetavel>().LimiteSpawn();

        }
    }
}
