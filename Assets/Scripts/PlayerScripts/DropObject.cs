using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DropObject : MonoBehaviour
{
    // Arraste o prefab do objeto que será dropado no inspector do Unity
    public GameObject objectToDrop;
    // Defina a rotação desejada para o objeto droppado
    public Vector3 dropRotation;
    // Variável para definir para quem a armadilha vai "olhar"
    public GameObject personagem;
    //
    public Button trapButton;
    public static int numTrap = 0;

    void Start()
    {

         // Verifique se o botão e o personagem estão configurados
        if (trapButton != null)
        {
            trapButton.onClick.AddListener(AcaoPersonagem);
        }
    }

    void Update()
    {
        // Verifica se a tecla F foi pressionada
        if (Input.GetKeyDown(KeyCode.F) && numTrap >= 0)
        {
            Drop();
            numTrap--;
        }

        //if ()

        Armadilha();
        if(personagem == null)
        {
            return;
        }
    }

    void Drop()
    {
       

        // Instancia o objeto na posição do personagem com a rotação especificada
        //Transform armadilha = Instantiate(objectToDrop, GameObject.FindWithTag("Player").transform).transform;
        Vector3 posicao = GameObject.FindWithTag("Player").transform.position;

        posicao.y += 3;
        posicao.z += 1;


        //armadilha.position = posicao;
        GameObject armadilha = Instantiate(objectToDrop, posicao, Quaternion.Euler(dropRotation));

        Debug.Log("???");
    }

    void AcaoPersonagem()
    {
        // Chame a ação do personagem
        PerformCharacterAction();
    }

    void PerformCharacterAction()
    {
        // Exemplo de ação: mover o personagem para frente
        personagem.transform.Translate(Vector3.forward * 1.0f);
        
        // Aqui você pode adicionar a lógica específica da ação que o personagem deve realizar
        Debug.Log("Ação do personagem executada!");
    }

    public void Armadilha()
    {
        GameObject Alvo = GameObject.FindWithTag("Player");
    }
}


