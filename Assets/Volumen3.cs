using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volumen3 : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixerNat;   
    public void CambiarVolumen(float volumen )
    {
        //audioMixerNat.setFloat("Volumen", volumen);
    }
}
