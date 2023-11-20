using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulleTouch : MonoBehaviour
{
    public static int compteur = 0; // Compteur statique pour le nombre de bulles détruites

    void OnMouseDown()
    {
        Debug.Log("La bulle a été touchée");
        Destroy(gameObject);

        // Si la bulle est détruite, incrémentez le compteur statique
        compteur++;
        Debug.Log("Compteur : " + compteur);
    }
}