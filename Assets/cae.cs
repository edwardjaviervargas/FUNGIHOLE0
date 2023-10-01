using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private bool isGameOver = false;

    

   

    // Define la posición Y en la que consideras que el jugador ha perdido.
    public float gameOverYPosition = -10f;

    // Guarda la posición inicial del jugador.
    private Vector3 initialPosition;
    
   
    private void Start()
    {
        // Almacenamos la posición inicial del jugador al comienzo del juego.
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (!isGameOver)
        {
            // Verifica la posición Y del jugador.
            if (transform.position.y <= gameOverYPosition)
            {
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over"); // Puedes personalizar el mensaje como desees.

        // Puedes mostrar un mensaje de "Game Over" en la pantalla o realizar otras acciones de fin de juego.

        // Reinicia la escena después de un breve retraso (puedes ajustar el tiempo según tus necesidades).
        Invoke("RestartScene", 2f);
    }

    private void RestartScene()
    {
        // Carga la escena actual para reiniciar el juego y coloca al jugador en la posición inicial.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}