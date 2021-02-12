using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public GameObject loadingScreen;

   public void PlayGame()
   {
      StartCoroutine(nameof(LoadLevel));
   }

   public void QuitGame()
   {
      Application.Quit();
   }

   IEnumerator LoadLevel()
   { 
      AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

      while (!asyncLoad.isDone)
      {
         loadingScreen.SetActive(true);
         yield return null;
      }
   }
}
