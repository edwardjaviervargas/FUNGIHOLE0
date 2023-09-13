using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrullar : MonoBehaviour
{

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] puntosMovimiento;
    [SerializeField] private float distanciaMinima;

    private int numeroAleatorio;
    
    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        numeroAleatorio = Random.Range(0, puntosMovimiento.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[numeroAleatorio].position, velocidadMovimiento * Time.deltaTime);

        if(Vector2.Distance(transform.position, puntosMovimiento[numeroAleatorio].position)< distanciaMinima)
        {
            numeroAleatorio = Random.Range(0,puntosMovimiento.Length);
            //Girar
            Girar();
        }
    }

    private void Girar ()
    {
        if (transform.position.x < puntosMovimiento[numeroAleatorio].position.x)
        {

            spriteRenderer.flipX = true;

        }
        else 
        { 
            spriteRenderer.flipX = false;
        }

    }

}
