using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulleTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
            Debug.Log("Ca a touché");
            Destroy(gameObject);
    }
        //DestroyImmediate (bullePrefab, true);
        //Destroy(this.bullePrefab);
}
