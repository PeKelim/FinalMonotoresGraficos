using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform puntoDeDisparo;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Bot�n izquierdo del mouse
        {
            Disparar();
        }
    }

    void Disparar()
    {
        // Instancia un nuevo proyectil en el punto de disparo
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDeDisparo.position, puntoDeDisparo.rotation);

        // Configura la direcci�n del proyectil seg�n la rotaci�n del punto de disparo
        proyectil.transform.forward = puntoDeDisparo.forward;
    }
}

