using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVida : MonoBehaviour
{
    [SerializeField] private float tiempoDeVida;
    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, tiempoDeVida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
