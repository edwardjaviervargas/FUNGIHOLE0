using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraDeVida : MonoBehaviour
{
    [SerializeField]private  Slider slider;



    // Start is called before the first frame update
    private void Start()

    {
        //slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    public void CambiarVidaMaxima(int vidaMaxima)
    {
        slider.maxValue = vidaMaxima;

    }
    public void CambiarVidaActual(int cantidadVida)
    {
        slider.value = cantidadVida;
    }
   public void InicializarBarraDeVida(int cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
        

    }}
