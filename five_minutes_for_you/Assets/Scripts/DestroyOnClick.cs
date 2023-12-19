using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject); // Détruire l'objet lors du clic
    }
}
