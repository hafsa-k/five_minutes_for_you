using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class BulleTouch : MonoBehaviour
{
    public GameObject messageUI; 
    public Button boutonRetour;
    public static int compteur = 0; // Compteur statique pour le nombre de bulles détruites
    
    void Start()
    {
        messageUI.SetActive(false); // Désactiver le message au démarrage du jeu
        
        boutonRetour.gameObject.SetActive(false);
        
    }
    void Update(){
         if (compteur >= 10) AfficherMessage();
    }
    void OnMouseDown()
    {
        Debug.Log("La bulle a été touchée");
        Destroy(gameObject);

        // Si la bulle est détruite, incrémentez le compteur statique
        compteur++;
        Debug.Log("Compteur : " + compteur);
    }

    void AfficherMessage()
    {
        // Affichez ici le message pour indiquer que le seuil a été atteint
        messageUI.SetActive(true);

        boutonRetour.gameObject.SetActive(true);
        boutonRetour.onClick.AddListener(RetourScenePrecedente); 
    }
    void RetourScenePrecedente()
    {
        // Chargez la scène précédente
        SceneManager.LoadScene("game 0");
    }
}