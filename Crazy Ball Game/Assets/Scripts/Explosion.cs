using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    public GameObject particles;
    public GameObject destroyedObject;

	void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Sphere" || collision.gameObject.CompareTag("Player"))
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(destroyedObject);
        }
    }
}
