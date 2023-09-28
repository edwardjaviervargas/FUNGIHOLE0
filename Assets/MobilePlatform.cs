using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlatform : MonoBehaviour
{
    public float speed = 2.0f; // Velocidad de movimiento de la plataforma
    public float range = 4.0f; // Distancia m�xima que la plataforma se mover�

    private Vector3 initialPosition;
    private float direction = 1.0f; // Direcci�n inicial de movimiento

    private void Start()
    {
        initialPosition = transform.position; // Almacena la posici�n inicial de la plataforma
    }

    private void Update()
    {
        // Calcula la nueva posici�n de la plataforma
        float newPositionX = initialPosition.x + (direction * range * Mathf.Sin(Time.time * speed));
        Vector3 newPosition = new Vector3(newPositionX, transform.position.y, transform.position.z);

        // Mueve la plataforma a la nueva posici�n
        transform.position = newPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Convierte al jugador en un hijo de la plataforma
            collision.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Desvincula al jugador de la plataforma
            collision.transform.parent = null;
        }
    }
}
