using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float da�o;


    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        
    }

    

        
   



}
