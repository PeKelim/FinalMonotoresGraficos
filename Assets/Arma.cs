using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform puntoDeDisparo;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Botón izquierdo del mouse
        {
            Disparar();
        }
    }

    void Disparar()
    {
        // Instancia un nuevo proyectil en el punto de disparo
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDeDisparo.position, puntoDeDisparo.rotation);

        // Configura la dirección del proyectil según la rotación del punto de disparo
        proyectil.transform.forward = puntoDeDisparo.forward;
    }
}

