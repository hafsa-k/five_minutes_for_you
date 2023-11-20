using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBehavior : MonoBehaviour
{
    public GameObject bullePrefab; // Le prefab de la bulle que vous souhaitez faire apparaître.
    public int nombreMaxBulles = 10; // Nombre maximum de bulles à faire apparaître.
    public float delaiMin = 1f; // Délai minimum avant l'apparition de la première bulle.
    public float delaiMax = 3f; // Délai maximum avant l'apparition de la première bulle.
    public float vitesseDeplacement = 1.0f;

    private float tempsAvantApparition;
    private float tempsEcoule;
    private int nombreBullesActuel;

    void Start()
    {
        // Initialiser le temps avant la première apparition au démarrage.
        tempsAvantApparition = Random.Range(delaiMin, delaiMax);
        tempsEcoule = 0;
        nombreBullesActuel = 0;
    }

    void Update()
    {
        tempsEcoule += Time.deltaTime;

        // Vérifier si le temps d'apparition de la bulle est écoulé et si le nombre de bulles actuel est inférieur au maximum.
        if (tempsEcoule >= tempsAvantApparition && nombreBullesActuel < nombreMaxBulles)
        {
            // Créer une nouvelle bulle à une position x aléatoire.
            float positionX = Random.Range(-2f, 2f); // Ajustez la plage de positions X selon vos besoins.
            Vector3 position = new Vector3(positionX, -5f, 0); // Assurez-vous que la valeur Y est en dessous de l'écran.

            // Instancier la bulle.
            GameObject nouvelleBulle = Instantiate(bullePrefab, position, Quaternion.identity);

            // Réinitialiser le temps avant la prochaine apparition.
            tempsAvantApparition = Random.Range(delaiMin, delaiMax);
            tempsEcoule = 0;

            // Incrémenter le nombre de bulles actuel.
            nombreBullesActuel++;
            
        }

        // Déplacer toutes les bulles existantes vers le haut.
        foreach (var bulle in GameObject.FindGameObjectsWithTag("Bubble"))
        {
            bulle.transform.Translate(Vector3.up * vitesseDeplacement * Time.deltaTime);
        }
        
        

    }
    

}