using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOptionsssss : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixerNat;

    public void CambiarVolumen(float volumen )
    {
        audioMixerNat.SetFloat("Volumen " , volumen);  
    }
}
