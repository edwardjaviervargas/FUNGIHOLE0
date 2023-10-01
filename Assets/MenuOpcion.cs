using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MenuOpcion : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer; 
    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);

    }
}
