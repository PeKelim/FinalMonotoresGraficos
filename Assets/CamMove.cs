using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerCamera : MonoBehaviour
{
    public float sensitivity = 2.0f; // Sensibilidad del mouse
    public float minimumX = -90f; //  ngulo m nimo en el eje X
    public float maximumX = 90f;  //  ngulo m ximo en el eje X
    public Transform player; // El transform del jugador

    private float rotationX = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Captura la entrada del mouse
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Calcula la rotaci n en el eje X
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

        // Aplica la rotaci n a la c mara en el eje Y
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

        // Rota el jugador en el eje Y
        player.transform.Rotate(Vector3.up * mouseX);
    }
}


