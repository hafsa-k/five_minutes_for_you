using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class ScaleFromMicrophone : MonoBehaviour
{
    public Animator animator;
    public AudioSource source; 
    public Vector3 minScale; 
    public Vector3 maxScale; 
    public audioLoudness detector;
    public int compteur = 0;
    public GameObject pissenlit;
    public float loudnessSensibility = 100; 
    public float threshold = 0.1f;

    public GameObject messageUI; 
    public Button boutonRetour;

    // Start is called before the first frame update
    void Start()
    {
        messageUI.SetActive(false); // Désactiver le message au démarrage du jeu
        
        boutonRetour.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
     void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;
        if (loudness >= threshold) {
            // Si le son est supérieur ou égal au seuil, activer l'animation
            animator.SetBool("AudioOn", true);
            compteur+=1;
        } else {
            // Sinon, désactiver l'animation
            animator.SetBool("AudioOn", false);
        }

        if (compteur >= 1500) AfficherMessage();;
    }

     void AfficherMessage()
    {
        pissenlit.SetActive(false);
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