using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelItem : MonoBehaviour
{
    public TextMesh textMesh;
    public string levelName;

	// Use this for initialization
	void Start ()
    {
        textMesh.text = levelName;
	}

    void OnMouseDown()
    {
        SceneManager.LoadScene(levelName);
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
            if(textMesh.text == "Level 1")
            {
                SceneManager.LoadScene("Level 1");
            }

            else if (textMesh.text == "Level 2")
            {
                SceneManager.LoadScene("Level 2");
            }

            else if(textMesh.text == "Level 3")
            {
                SceneManager.LoadScene("Level 3");
            }

            else if (textMesh.text == "Level 4")
            {
                SceneManager.LoadScene("Level 4");
            }

            else if (textMesh.text == "Level 5")
            {
                SceneManager.LoadScene("Level 5");
            }

            else if (textMesh.text == "Level 6")
            {
                SceneManager.LoadScene("Level 6");
            }

            else if (textMesh.text == "Level 7")
            {
                SceneManager.LoadScene("Level 7");
            }

            else if (textMesh.text == "Level 8")
            {
                SceneManager.LoadScene("Level 8");
            }

        }
        
    }
	
}