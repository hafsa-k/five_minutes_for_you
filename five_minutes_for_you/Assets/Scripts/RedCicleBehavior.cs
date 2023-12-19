using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCircleBehavior : MonoBehaviour
{
    public GameObject circlePrefab;
    public List<Transform> spawnPoints = new List<Transform>();
    public int numberOfCircles = 5;
    public GameObject messageUI;

    private int remainingCircles;

    void Start()
    {
        messageUI.SetActive(false);
        remainingCircles = numberOfCircles;

        if (circlePrefab != null && spawnPoints.Count > 0 && messageUI != null)
        {
            List<Transform> usedSpawnPoints = new List<Transform>();

            for (int i = 0; i < numberOfCircles; i++)
            {
                int spawnIndex = Random.Range(0, spawnPoints.Count);

                while (usedSpawnPoints.Contains(spawnPoints[spawnIndex]))
                {
                    spawnIndex = Random.Range(0, spawnPoints.Count);
                }

                usedSpawnPoints.Add(spawnPoints[spawnIndex]);

                GameObject newCircle = Instantiate(circlePrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
                newCircle.AddComponent<DestroyOnClick>();
            }
        }
        else
        {
            Debug.LogError("Veuillez assigner le prefab du cercle, définir les points d'apparition et le GameObject messageUI.");
        }
    }

    public class DestroyOnClick : MonoBehaviour
    {
        private RedCircleBehavior redCircleBehavior;

        private void Start()
        {
            redCircleBehavior = GameObject.FindObjectOfType<RedCircleBehavior>();
        }

        private void OnMouseDown()
        {
            redCircleBehavior.DecreaseCircleCount();
            Destroy(gameObject);
        }
    }

    public void DecreaseCircleCount()
    {
        remainingCircles--;

        if (remainingCircles <= 0)
        {
            messageUI.SetActive(true);
        }
    }
}
