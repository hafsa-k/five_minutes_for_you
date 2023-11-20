using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromMicrophone : MonoBehaviour
{
    public Animator animator;
    public AudioSource source; 
    public Vector3 minScale; 
    public Vector3 maxScale; 
    public audioLoudness detector;

    public float loudnessSensibility = 100; 
    public float threshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;
        if (loudness >= threshold) {
            // Si le son est supérieur ou égal au seuil, activer l'animation
            animator.SetBool("AudioOn", true);
        } else {
            // Sinon, désactiver l'animation
            animator.SetBool("AudioOn", false);
        }
    }
}
