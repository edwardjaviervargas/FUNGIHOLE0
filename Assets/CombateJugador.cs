using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CombateJugador : MonoBehaviour
{
    
    [SerializeField] int vida;
    [SerializeField] int maximoVida;
    [SerializeField] private BarraDeVida barraDeVida;
    float xInicial, yInicial;
    [SerializeField] private int vidaMaxima;


    private Animator animator;

    public event EventHandler MuerteJugador;

    private Rigidbody2D rb2D;

    


    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);
        xInicial = transform.position.x;
        yInicial = transform.position.y;
        rb2D = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    public void TomarDaño(int daño)
    {
        
        vida -= daño;
        barraDeVida.CambiarVidaActual(vida);
        if (vida > 0)
        {
            animator.SetTrigger("Golpe");
        }
        else
        {
            rb2D.constraints = RigidbodyConstraints2D.FreezeAll;
            animator.SetTrigger("Dead");
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Jugador"), LayerMask.NameToLayer("Enemigo"),
                true);

        }

        if (vida <= 0)
        {
            MuerteJugador?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
        }
    }
    public void Recolocar()
    {
        transform.position = new Vector3(xInicial, yInicial, 0);
    }
    public void MuerteJugadorEvento()
    {
       // MuerteJugador?.Invoke(this, EventArgs.Empty);
    }


}
