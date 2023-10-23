using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonBehavior : MonoBehaviour
{
   public void PlayMiniGame()
   {
        SceneManager.LoadSceneAsync(1);
   }
}
