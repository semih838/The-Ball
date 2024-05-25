using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour
{
    public GameObject DeadObject;
    public float time;

    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("CreateObject", 0, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObject()
    {
        Instantiate(DeadObject, transform.position, transform.rotation);
    }
}
