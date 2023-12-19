using UnityEngine;
using UnityEngine.UI;

public class ContadorUI : MonoBehaviour
{
    public GameController gameController; // Asegúrate de asignar el GameController desde el Inspector
    public Text textoContador;

    private void Update()
    {
        // Actualiza el texto del contador con la cantidad de enemigos eliminados

        textoContador.text = "Enemigos Eliminados: " + gameController.enemigosEliminados.ToString();


    }
}
