using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform sphere;
	
	// Update is called once per frame
	void Update ()
    {
        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();
            
        Vector3 vector = new Vector3(0, 5f, -5f);
        float velocity = rigidbody.velocity.sqrMagnitude;
        vector = vector * (0.85f + velocity / 25f);
        
        Vector3 newPosition = sphere.position + vector;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * 2f);
        transform.LookAt(sphere);
    }
}
