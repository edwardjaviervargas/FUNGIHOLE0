using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateJugador : MonoBehaviour
{
    [SerializeField] int vida;
    [SerializeField] int maximoVida;
    [SerializeField] private BarraDeVida barraDeVida;
    float xInicial, yInicial;


    // Start is called before the first frame update
    private void Start()
    {
        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);
        xInicial = transform.position.x;
        yInicial = transform.position.y;

    }

    // Update is called once per frame
    public void TomarDa�o(int da�o)
    {
        vida -= da�o;
        barraDeVida.CambiarVidaActual(vida);
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void Recolocar()
    {
        transform.position = new Vector3(xInicial, yInicial, 0);
    }

}
