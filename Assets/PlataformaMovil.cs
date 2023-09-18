using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    [SerializeField] private Transform[] puntoMovimiento;

    [SerializeField] private float velocidadMovimiento;

    private int siguientePlataforma = 1;

    private bool ordenPlataforma = true;

    private void Update()
    {
        if (ordenPlataforma && siguientePlataforma + 1 >= puntoMovimiento.Length)
        {
            ordenPlataforma = false;
        }
        if (ordenPlataforma && siguientePlataforma <= 0 ) 
        {
            ordenPlataforma = true;

        }
        if(Vector2.Distance(transform.position, puntoMovimiento[siguientePlataforma].position) < 0.1f)
        {
            if (ordenPlataforma)
            {
                siguientePlataforma += 1;
            }
            else
            {
                siguientePlataforma -= 1;
            }

    
        

        }
        transform.position = Vector2.MoveTowards(transform.position, puntoMovimiento[siguientePlataforma].position,
            velocidadMovimiento * Time.deltaTime);
    }





}
