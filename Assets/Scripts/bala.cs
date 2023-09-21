using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float dañoB;

    [SerializeField] private Transform controladorDisparo;

    [SerializeField] private float radioGolpe;


    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);


        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorDisparo.position, radioGolpe);

        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Enemy"))
            {
                colisionador.transform.GetComponent<Boss>().TomarDaño(dañoB);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorDisparo.position, radioGolpe);
    }











}
