using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
   
    float xInicial, yInicial;
    
    private Rigidbody2D rb2D;

    [Header("Movimiento")]

    private float movimientoHorizontal = 0f;

    [SerializeField] private float velocidadDeMovimiento;

    [Range(0, 0.3f)][SerializeField] private float suavizadoDeMovimiento;

    private Vector3 velocidad = Vector3.zero;

    private bool mirandoDerecha = true;

    [Header("Salto")]

    [SerializeField] private float fuerzaDeSalto;

    [SerializeField] private LayerMask queEsSuelo;

    [SerializeField] private Transform controladorSuelo;

    [SerializeField] private Vector3 dimensionesCaja;

    [SerializeField] private bool enSUelo;

    private bool salto = false;

    [Header("Animacion")]

    [Header("Rebote")]

    [SerializeField] private float velocidadRebote;


    private Animator animator;


    private void  Start()

    {
        rb2D = GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();

        xInicial = transform.position.x;
        yInicial = transform.position.y;



    }

    
    private void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadDeMovimiento;

        animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal));


        if (Input.GetButtonDown("Jump"))
        {
            salto = true;
        }

    }
    private void FixedUpdate()
        
    {
        enSUelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);

        //MOver
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);
        salto = false;

    }
    private void Mover(float mover, bool saltar)
    {

        Vector3 velocidadObjetivo = new Vector2(mover, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, suavizadoDeMovimiento);

        if (mover > 0 && !mirandoDerecha)
        {
            //Girar
            Girar();
        }
        else if (mover < 0 && mirandoDerecha)
        {
            //Girar
            Girar();

        }
        if(enSUelo && saltar)
        {
            enSUelo = false;
            rb2D.AddForce(new Vector2(0f, fuerzaDeSalto));

        }

        
    }
    private void Rebote()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, velocidadRebote);

        Rebote();

    }
    

    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionesCaja);

    }
    public void Recolocar()
    {
        transform.position = new Vector3(xInicial, yInicial, 0);
    }
}
