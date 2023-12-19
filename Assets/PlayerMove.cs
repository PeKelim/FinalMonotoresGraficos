using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Velocidad de movimiento
    public float jumpForce = 7.0f; // Fuerza de salto
    private bool isGrounded; // Variable para verificar si el personaje est� en el suelo

    void Update()
    {
        // entrada de movimiento
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // direcci�n de movimiento
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

        // Aplica el movimiento en funci�n de la direcci�n
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Maneja el salto
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        // Aplica una fuerza hacia arriba para simular el salto
        GetComponent<Rigidbody>().velocity = new Vector3(0, jumpForce, 0);
        // Marca que el personaje no est� en el suelo
        isGrounded = false;
    }

    // M�todo llamado cuando el objeto entra en contacto con un collider (el suelo)
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisionamos tiene la etiqueta "Suelo"
        if (collision.gameObject.CompareTag("Untagged"))
        {
            // Marca que el personaje est� en el suelo
            isGrounded = true;
        }
    }
}
