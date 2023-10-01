using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ColisionInferior : MonoBehaviour
{
    private bool isGameOver = false;

    // Define la posici�n y en la que se considera que el jugador ha perdido
    public float gameOverYPosition = -10f;

    void Update()
    {
        if (!isGameOver)
        {
            // Verifica la posici�n del jugador en el eje Y
            if (transform.position.y <= gameOverYPosition)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        isGameOver = true;
        // Puedes mostrar un mensaje de "Game Over" en la pantalla aqu� o realizar otras acciones de fin de juego.

        // Recarga la escena actual para reiniciar el juego.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}