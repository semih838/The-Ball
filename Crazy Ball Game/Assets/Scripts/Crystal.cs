using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crystal : MonoBehaviour
{
    public GameObject particles;

    void OnTriggerEnter(Collider collision)
    {
      if (collision.gameObject.CompareTag("Player"))
        {
            if (LeaveCrystals() == 1)
            {
                LoadNextLevel();
            }

            else
            {
                Instantiate(particles, transform.position, Quaternion.identity);

                gameObject.SetActive(false);
            }
        }
    }

    void LoadNextLevel()
    {
        string currentLevel = SceneManager.GetActiveScene().name;

        int currentLevelNumber = Int32.Parse(currentLevel.Substring(currentLevel.IndexOf("") + 6));

        string nextLevel = "Level " + (currentLevelNumber + 1).ToString();

        SceneManager.LoadScene(nextLevel);     
    }


    int LeaveCrystals()
    {
        Crystal[] crystals =  Component.FindObjectsOfType<Crystal>();
        return crystals.Length;
    }    
}