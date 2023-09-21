using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction;
    public float livingTime = 3f;

    [SerializeField] private float damage;

    [SerializeField] private Transform controlshoot;

    [SerializeField] private float smash;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, livingTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = direction.normalized * speed * Time.deltaTime;

        //transform.position = new Vector2(transform.position.x + movement.x, transform.position.y + movement.y);

        transform.Translate(movement);


        transform.Translate(Vector2.right * speed * Time.deltaTime);


        Collider2D[] objetos = Physics2D.OverlapCircleAll(controlshoot.position, smash);

        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Player"))
            {
                colisionador.transform.GetComponent<CombateJugador>().TomarDaño(damage);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controlshoot.position, smash);
    }

}
