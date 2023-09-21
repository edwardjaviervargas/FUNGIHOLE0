using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Animator animator;
    public Rigidbody2D rib2D;
    public Transform jugador;
    private bool mirandoDerecha = true;

    public GameObject proyectilPrefab;
    public float tiempoDisparo = 2.0f;
    public float rangoDeDeteccion = 5.0f;
    private float tiempoUltimoDisp;
    private Transform _firePoint;
    public GameObject shooter;


    [Header("Vida")]
    [SerializeField] private float life;
    [SerializeField] private float lifeMax;
    [SerializeField] private barraVida barraDeVidaa;


    [SerializeField] private Transform controladorAtaque;
    [SerializeField] private float radioAtaque;
    [SerializeField] private float dañoAtaque;


    // Start is called before the first frame update
    private void Start()
    {
        life = lifeMax;
        animator = GetComponent<Animator>();
        rib2D = GetComponent<Rigidbody2D>();
        barraDeVidaa.IniciarVida(life);
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        tiempoUltimoDisp = Time.time;

    }
    public void Awake()
    {
        _firePoint = transform.Find("firePoint");

    }
    private void Update()
    {
        float distanciaJugador = Vector2.Distance(transform.position, jugador.position);
        animator.SetFloat("distanciaJugador", distanciaJugador);

        float distanciaAlJugaor = Vector2.Distance(transform.position, jugador.position);

        if (distanciaAlJugaor <= rangoDeDeteccion)
        {
            if (Time.time - tiempoUltimoDisp >= tiempoDisparo)
            {
                Disparar();
                tiempoUltimoDisp = Time.time;
            }
        }

    }

    void Disparar() 
    {
    
       // Instantiate(proyectilPrefab, transform.position, Quaternion.identity);

        //Instantiate(proyectilPrefab, _firePoint.transform.position, Quaternion.identity);


        if (proyectilPrefab != null && _firePoint != null && shooter != null)
        {
            GameObject myBullet = Instantiate(proyectilPrefab, _firePoint.position, Quaternion.identity) as GameObject;
            bullet bulletComponente = myBullet.GetComponent<bullet>();

            if (shooter.transform.localScale.x < 0f)
            {
                bulletComponente.direction = Vector2.left;
            }
            else
            {
                bulletComponente.direction = Vector2.right;
            }


        }
    }

    // Update is called once per frame
    public void TomarDaño(float dañoB)
    {
        life -= dañoB;
        barraDeVidaa.changeLifeAc(life);

        if (life <= 0)
        {
            animator.SetTrigger("Muerte");
        }
    }

    private void Muerte()
    {
        Destroy(gameObject);
    }

    public void MirarJugador()
    {
        if ((jugador.position.x > transform.position.x && !mirandoDerecha) || (jugador.position.x < transform.position.x && mirandoDerecha))
        {
            mirandoDerecha = !mirandoDerecha;
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);

        }

    }

    public void Ataque() 
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorAtaque.position, radioAtaque);

        foreach (Collider2D colision in objetos)
        {
            if (colision.CompareTag("Player"))
            {
               // colision.GetComponent<CombateJugador>().TomarDaño(dañoAtaque);
            }
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(controladorAtaque.position, radioAtaque);
    }

}
