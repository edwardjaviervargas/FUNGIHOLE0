using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class MenuGameOver : MonoBehaviour

{
    
    [SerializeField] private GameObject menuGameOver;

    private CombateJugador combateJugador;

    private void Start()
    {
        combateJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<CombateJugador>();
        combateJugador.MuerteJugador += Activarmenu;
        

    }
    private void Activarmenu(object sender, EventArgs e)
    {
        menuGameOver.SetActive(true);
    }

    public void Reiniciar()
    {
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Jugador"), LayerMask.NameToLayer("Enemigo"),
                false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
       // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    }
}
