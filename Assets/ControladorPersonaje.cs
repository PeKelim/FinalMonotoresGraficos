using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    private Animator animador;

    void Start()
    {
        // Obt�n el componente Animator del personaje
        animador = GetComponent<Animator>();

        // Inicia la animaci�n "Zombie@Walk"
        IniciarAnimacion("Zombie@Walk01");
    }

    void IniciarAnimacion(string nombreAnimacion)
    {
        // Establece el disparador correspondiente para iniciar la animaci�n
        animador.SetTrigger(nombreAnimacion);
    }
}
