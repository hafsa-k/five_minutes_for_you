using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goBackBehavior : MonoBehaviour
{
    public GameObject messageUI;
    public GameObject[] objectsWithTagToCheck; // Ajoutez ici les références à vos gameObjects avec les tags

    void Start()
    {
        messageUI.SetActive(false); // Désactiver le message au démarrage du jeu
    }

    void Update()
    {
        bool allDestroyed = true;

        // Vérifie si tous les gameObjects avec les tags spécifiques sont détruits
        foreach (GameObject objWithTag in objectsWithTagToCheck)
        {
            if (objWithTag != null) // Si l'objet n'est pas détruit
            {
                allDestroyed = false; // Au moins un objet est encore présent
                break; // Sortir de la boucle dès qu'un objet est trouvé
            }
        }

        // Si tous les gameObjects avec les tags spécifiques sont détruits, affichez le message
        if (allDestroyed)
        {
            AfficherMessage();
        }
    }

    void AfficherMessage()
    {
        messageUI.SetActive(true); // Afficher le message
    }
}
