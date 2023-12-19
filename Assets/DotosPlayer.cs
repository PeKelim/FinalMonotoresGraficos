using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class DatosPlayer : MonoBehaviour
{
    public Text gameOver;
    public float vidaPlayer;
    public Slider vidaVisual;
    public GameObject gameOverPanel;
    public Text gameOverText;

    public GameObject bullet;
    public Transform firePoint;

    private void Start()
    {

        gameOver.enabled = false;
        // Desactiva el panel y el texto al inicio
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer <= 0)
        {
            Debug.Log("GAME OVER");

            gameOver.enabled = true;

            // Desactiva el panel de Game Over si ya estaba activo
            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(false);
            }

            // Muestra el texto de Game Over
            if (gameOverText != null)
            {
                gameOverText.gameObject.SetActive(true);
            }

            // Reinicia el nivel después de un tiempo (puedes ajustar el tiempo según tus necesidades)
            StartCoroutine(ReiniciarNivelDespuesDeEspera());
        }


        //shooting

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }





    }


    // Corrutina para reiniciar el nivel después de un tiempo de espera
    IEnumerator ReiniciarNivelDespuesDeEspera()
    {
        yield return new WaitForSeconds(3f); // Espera 3 segundos 
        // Carga el nivel actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
