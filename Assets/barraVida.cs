using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraVida : MonoBehaviour
{

    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void changeLifeMx(float lifeMax) 
    {
        slider.maxValue = lifeMax;
    
    }

    public void changeLifeAc(float life) 
    {
        slider.value = life;
    }
    public void IniciarVida(float life) 
    {
        changeLifeMx(life);
        changeLifeAc(life);

    }
    
}
