using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habilidad : MonoBehaviour
{

    [SerializeField] private float daño;
    [SerializeField] private Vector2 dimesionesCaja;
    [SerializeField] private Transform posicionCaja;
    [SerializeField] private float tiempoDeVida;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }

    public void Golpe()
    {
        Collider2D[] objetos = Physics2D.OverlapBoxAll(posicionCaja.position, dimesionesCaja, 0f);

        foreach(Collider2D colisiones in objetos)
        {
            if (colisiones.CompareTag("Player"))
            {
               // colisiones.GetComponent<CombateJugador>().TomarDaño(daño);
            }



        }



    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireCube(posicionCaja.position, dimesionesCaja);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
