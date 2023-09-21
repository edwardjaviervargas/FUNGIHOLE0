using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaTemporal : MonoBehaviour
{
    [SerializeField] private float tiempoEspera;

    private Rigidbody2D rb2D;


    [SerializeField] private float velocidadRotacion;

    private Animator animator;

    private bool caida = false;

    public PlataformaTemporal(bool caida)
    {
        this.caida = caida;
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Caida(other));

;
        }

    }
    private IEnumerator Caida(Collision2D other) 
    {
        yield return new WaitForSeconds(tiempoEspera);
        caida = true;
        Physics2D.IgnoreCollision(transform.GetComponent<Collider2D>(), other.transform.GetComponent<Collider2D>());
        rb2D.constraints = RigidbodyConstraints2D.None;
        rb2D.AddForce(new Vector2(01f, 0));


    }

}
