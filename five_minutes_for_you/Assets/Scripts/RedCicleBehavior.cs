using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCicleBehavior : MonoBehaviour
{
    public GameObject cercleRougePrefab; // Référence à l'objet cercle rouge que vous voulez afficher
    public List<Transform> emplacements = new List<Transform>(); // Liste des emplacements où le cercle peut apparaître
    public int nombreApparitions = 5; // Nombre de cercles à faire apparaître

    void Start()
    {
        if (cercleRougePrefab != null && emplacements.Count > 0)
        {
            int nombreEmplacements = emplacements.Count;

            // Utilisation d'une liste temporaire pour éviter la répétition des emplacements
            List<Transform> emplacementsUtilises = new List<Transform>();

            // Faire apparaître le nombre défini de cercles rouges
            for (int i = 0; i < nombreApparitions; i++)
            {
                int indexEmplacement = Random.Range(0, nombreEmplacements);

                // S'assurer que l'emplacement n'a pas été utilisé précédemment
                while (emplacementsUtilises.Contains(emplacements[indexEmplacement]))
                {
                    indexEmplacement = Random.Range(0, nombreEmplacements);
                }

                emplacementsUtilises.Add(emplacements[indexEmplacement]);

                // Instancier le cercle rouge à l'emplacement sélectionné
                Instantiate(cercleRougePrefab, emplacements[indexEmplacement].position, Quaternion.identity);
            }
            
             
        }
        else
        {
            Debug.LogError("Veuillez assigner le prefab du cercle rouge et définir les emplacements.");
        }
    }
    
}
