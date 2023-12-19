using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector2 difference = Vector2.zero;
    private bool isBeingDragged = false;

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        isBeingDragged = true;
    }

    private void OnMouseDrag()
    {
        if (isBeingDragged)
        {
            Vector2 newPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
            transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
        }
    }

    private void OnMouseUp()
    {
        isBeingDragged = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("redObject") && collision.gameObject.CompareTag("red"))
        {
            Destroy(gameObject);
        }

        if (gameObject.CompareTag("blueObject") && collision.gameObject.CompareTag("blue"))
        {
            Destroy(gameObject);
        }

        if (gameObject.CompareTag("yellowObject") && collision.gameObject.CompareTag("yellow"))
        {
            Destroy(gameObject);
        }
    }
}
