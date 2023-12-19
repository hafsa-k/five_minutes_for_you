/*using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Ne pas détruire le GameObject lors du changement de scène
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Ajoutez ici le code pour la lecture de la musique, par exemple :
     void Start()
     {
        GetComponent<AudioSource>().Play(); // Jouer la musique au démarrage du jeu
     }
}*/
