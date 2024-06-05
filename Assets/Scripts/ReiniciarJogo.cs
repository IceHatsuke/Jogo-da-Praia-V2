using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarJogo : MonoBehaviour
{
    
    // Este método será chamado quando o botão Reiniciar for pressionado
    public void ReiniciaJogo()
    {
        // Recarrega a cena atual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
