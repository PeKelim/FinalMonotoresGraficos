using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int damage;
    public float velocidad = 2f; // Velocidad de movimiento del enemigo
    public int vidaMaxima = 100; // Vida máxima del enemigo
    private int vidaActual; // Vida actual del enemigo
    public Transform objetivo;
    public GameController gameController;
    private void Start()
    {
        vidaActual = vidaMaxima;
    }

    private void Update()
    {
        // Verifica que el objetivo no sea null
        if (objetivo != null)
        {
            // Calcula la dirección hacia el jugador
            Vector3 direccion = (objetivo.position - transform.position).normalized;

            // Mueve al enemigo en la dirección hacia el jugador
            transform.Translate(direccion * velocidad * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DatosPlayer datosPlayer = other.GetComponent<DatosPlayer>();
            if (datosPlayer != null)
            {
                datosPlayer.vidaPlayer -= damage;
            }
        }
        else if (other.CompareTag("Enemigo"))
        {
            Debug.Log("ESTO ES OTRO ENEMIGO");
        }
        else if (other.CompareTag("Bullet"))
        {
            // La colisión es con una bala
            // Resta vida al enemigo y destruye la bala
            TomarDanio(10); // Ajusta la cantidad de daño que quieras que haga la bala
            Destroy(other.gameObject);
        }
    }

    void TomarDanio(int cantidadDanio)
    {
        vidaActual -= cantidadDanio;

        // Verificar si el enemigo aún tiene vida
        if (vidaActual <= 0)
        {
            // Puedes agregar acciones adicionales aquí, como reproducir efectos de muerte o sonidos

            // Destruir el enemigo
            gameController.enemigosEliminados++;

            Destroy(gameObject);
        }
    }
}
