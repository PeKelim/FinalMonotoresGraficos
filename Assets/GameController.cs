using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int enemigosEliminados = 0;
    public int metaEnemigos = 25;
    public GameObject cartelGanador;

    private void Update()
    {
        // Verificar si se alcanzó la meta de enemigos eliminados
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

        // Puedes agregar acciones adicionales aquí, como reproducir efectos de victoria o sonidos

        // Reiniciar el nivel después de unos segundos (ajusta el tiempo según tus necesidades)
        Invoke("ReiniciarNivel", 3f);
    }

    void ReiniciarNivel()
    {
        // Obtener el índice de la escena actual
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Reiniciar la escena actual
        SceneManager.LoadScene(indiceEscenaActual);
    }

    // Método para incrementar el contador de enemigos eliminados
    public void IncrementarContadorEnemigos()
    {
        enemigosEliminados++;
    }
}
