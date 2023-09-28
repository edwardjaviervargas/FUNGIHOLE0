    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;

    [SerializeField] private GameObject bala;

    [SerializeField] private AudioSource sonidoDisparo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            //disparar
            Disparar();

        }
    }

    private void Disparar()
    {
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
        sonidoDisparo.Play();

    }
}
