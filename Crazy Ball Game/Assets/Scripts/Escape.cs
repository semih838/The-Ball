using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == Helper.MENU)
            {
                return;
            }

            else
            {
                SceneManager.LoadScene(Helper.MENU);
            }

        }
	}
}