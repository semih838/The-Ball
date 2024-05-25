using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    //GameObject dead_ball;

    void OnTriggerEnter(Collider collision)
    {
        //zabijanie gracza
        if(collision.gameObject.name == "Sphere")
        {
            string levelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(levelName);
        }

        if (collision.gameObject.name == "dead_ball" || collision.gameObject.name == "dead_ball(Clone)")
        {
            Destroy(collision.gameObject);
        }
    }
}
