using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    // Arraste o prefab do objeto que será dropado no inspector do Unity
    public GameObject objectToDrop;
    // Defina a rotação desejada para o objeto droppado
    public Vector3 dropRotation;
    // Variável para definir para quem a armadilha vai "olhar"
    public GameObject trapAlvo;

    void Update()
    {
        // Verifica se a tecla F foi pressionada
        if (Input.GetKeyDown(KeyCode.F))
        {
            Drop();
        }

        Armadilha();
        if(trapAlvo == null)
        {
            return;
        }
    }

    void Drop()
    {
        // Converte a rotação em Euler (Vector3) para Quaternion
        Quaternion rotation = Quaternion.Euler(dropRotation);

        // Instancia o objeto na posição do personagem com a rotação especificada
        Instantiate(objectToDrop, transform.position, rotation);
    }

    public void Armadilha()
    {
        GameObject Alvo = GameObject.FindWithTag("Player");
    }
}
