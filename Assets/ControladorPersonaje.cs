using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    private Animator animador;

    void Start()
    {
        // Obtén el componente Animator del personaje
        animador = GetComponent<Animator>();

        // Inicia la animación "Zombie@Walk"
        IniciarAnimacion("Zombie@Walk01");
    }

    void IniciarAnimacion(string nombreAnimacion)
    {
        // Establece el disparador correspondiente para iniciar la animación
        animador.SetTrigger(nombreAnimacion);
    }
}
