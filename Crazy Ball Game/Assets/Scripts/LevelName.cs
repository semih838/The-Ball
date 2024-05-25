using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelName : MonoBehaviour
{
    public TextMesh textMesh;

	void Start ()
    {
        textMesh.text = SceneManager.GetActiveScene().name;
    }
}
