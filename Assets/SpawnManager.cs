using UnityEngine;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public Transform puntoSpawn;
    public float tiempoEntreSpawns = 2f;

    void Start()
    {
        // Inicia el spawn de enemigos
        InvokeRepeating("SpawnEnemigo", 0f, tiempoEntreSpawns);
    }

    void SpawnEnemigo()
    {
        // Instancia un nuevo enemigo en el punto de spawn
        GameObject nuevoEnemigo = Instantiate(enemigoPrefab, puntoSpawn.position, puntoSpawn.rotation);

        // Puedes configurar más propiedades del enemigo aquí si es necesario
    }
}
