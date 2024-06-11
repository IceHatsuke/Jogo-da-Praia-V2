using UnityEngine;

public class Trap : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que colidiu possui a tag "Inimigo"
        if (other.CompareTag("Inimigo"))
        {
            // Destroi a armadilha
            Destroy(gameObject);
        }
    }
}
