using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3; // Establece la cantidad m�xima de puntos de vida del jugador.
    private int currentHealth; // Lleva un registro de la salud actual del jugador.
    private Animator animator; // Referencia al componente Animator del jugador.
    private bool isDead = false; // Variable para evitar que se repita la animaci�n de muerte.

    private void Start()
    {
        currentHealth = maxHealth; // Inicializa la salud actual con el valor m�ximo al comienzo del juego.
        animator = GetComponent<Animator>(); // Obtiene el componente Animator del jugador.
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return; // Evita que se siga procesando si el jugador ya est� muerto.

        currentHealth -= damage; // Reduce la salud actual del jugador seg�n el da�o recibido.

        if (currentHealth <= 0)
        {
            Die(); // Llama a la funci�n Die() si la salud del jugador llega a cero o menos.
        }
    }

    private void Die()
    {
        // Realiza acciones de muerte aqu�, como reproducir una animaci�n y detener el movimiento del jugador.

        // Reproduce la animaci�n de muerte si hay un componente Animator.
        if (animator != null)
        {
            animator.SetTrigger("Dead"); // Aqu� asumimos que tienes un par�metro "Dead" en tu Animator que inicia la animaci�n de muerte.
        }

        // Puedes desactivar otros scripts o componentes del jugador si es necesario.

        // Marca al jugador como muerto para evitar que se siga procesando.
        isDead = true;
    }
}
