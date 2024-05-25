using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public GameObject ballPrefab;
    public Camera cameraPrefab;
    public Light lightPrefab;
    public BoxCollider borderPrefab;
    public Text levelTextPrefab;
    public Canvas canvasPrefab;

	// Use this for initialization
	void Start ()
    {
        GameObject Sphere = GameObject.Instantiate(ballPrefab);
        Sphere.name = "Sphere";
        Sphere.transform.position = transform.position + Vector3.up * 2f;

        Camera camera = GameObject.Instantiate(cameraPrefab);
        CameraController cameraController = camera.GetComponent<CameraController>();
        cameraController.sphere = Sphere.transform;

        BoxCollider border = GameObject.Instantiate(borderPrefab);

        InitLighting();
        InitText();
	}

    private void InitLighting()
    {
        Light light = GameObject.Instantiate(lightPrefab);
        light.color = Color.white;
        light.intensity = 0.5f;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = Color.white * 0.7f;
    }

    private void InitText()
    {
        string level = SceneManager.GetActiveScene().name;
        levelTextPrefab.text = level;

        Canvas canvas = GameObject.Instantiate(canvasPrefab);
    }

    // Update is called once per frame
    void Update ()
    {
	
	}
}
