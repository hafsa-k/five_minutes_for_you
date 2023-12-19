using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeBehavior : MonoBehaviour
{
    public GameObject messageUI;


    void Start()
    {
        messageUI.SetActive(false);
        // Démarrer le timer de 40 secondes
        Invoke("ShowMessageUI", 40f);
    }

    void ShowMessageUI()
    {
        // Activer le message UI après 40 secondes
        if (messageUI != null)
        {
            messageUI.SetActive(true);
        }
    }
}
