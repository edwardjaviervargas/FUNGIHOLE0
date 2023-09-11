using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    // Start is called before the first frame update
    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;

    }
    
        
   

    // Update is called once per frame
    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
        
    }
    public void CambiarCalidad(int index) 
    {
        QualitySettings.SetQualityLevel(index);

    }
}
