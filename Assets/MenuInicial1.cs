using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuInicial1 : MonoBehaviour
{

    public void CargarEscena(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Cargarescena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
