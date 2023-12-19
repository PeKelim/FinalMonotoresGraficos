using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int enemigosEliminados = 0;
    public int metaEnemigos = 25;
    public GameObject cartelGanador;

    private void Update()
    {
        // Verificar si se alcanz� la meta de enemigos eliminados
        if (enemigosEliminados >= metaEnemigos)
        {
            MostrarCartelGanador();
        }
    }

    void MostrarCartelGanador()
    {
        // Mostrar el cartel de ganadora
        if (cartelGanador != null)
        {
            cartelGanador.SetActive(true);
        }

        // Puedes agregar acciones adicionales aqu�, como reproducir efectos de victoria o sonidos

        // Reiniciar el nivel despu�s de unos segundos (ajusta el tiempo seg�n tus necesidades)
        Invoke("ReiniciarNivel", 3f);
    }

    void ReiniciarNivel()
    {
        // Obtener el �ndice de la escena actual
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Reiniciar la escena actual
        SceneManager.LoadScene(indiceEscenaActual);
    }

    // M�todo para incrementar el contador de enemigos eliminados
    public void IncrementarContadorEnemigos()
    {
        enemigosEliminados++;
    }
}
