using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCanvas : MonoBehaviour
{
    public Transform enemyTransform; // Referência ao Transform do inimigo

    void Update()
    {
        if (enemyTransform != null)
        {
            // Atualiza a posição do Canvas para seguir o inimigo
            transform.position = enemyTransform.position;
        }
    }
}
