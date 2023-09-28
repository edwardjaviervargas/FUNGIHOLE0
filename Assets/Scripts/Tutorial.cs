using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorialCanvas1;
    public GameObject tutorialCanvas2;
    public GameObject tutorialCanvas3;
    public GameObject tutorialCanvas4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            string colliderTag = gameObject.tag;

            // Activa el Canvas correspondiente según el tag del Collider.
            if (colliderTag == "Tutorial1")
            {
                tutorialCanvas1.SetActive(true);
            }
            else if (colliderTag == "Tutorial2")
            {
                tutorialCanvas2.SetActive(true);
            }
            else if (colliderTag == "Tutorial3")
            {
                tutorialCanvas3.SetActive(true);
            }
            else if (colliderTag == "Tutorial4")
            {
                tutorialCanvas4.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            string colliderTag = gameObject.tag;

            // Desactiva el Canvas correspondiente según el tag del Collider.
            if (colliderTag == "Tutorial1")
            {
                tutorialCanvas1.SetActive(false);
            }
            else if (colliderTag == "Tutorial2")
            {
                tutorialCanvas2.SetActive(false);
            }
            else if (colliderTag == "Tutorial3")
            {
                tutorialCanvas3.SetActive(false);
            }
            else if (colliderTag == "Tutorial4")
            {
                tutorialCanvas4.SetActive(false);
            }
        }
    }
}
