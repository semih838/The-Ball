using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float mobileSpeed;
    public float gyroMultiplier;

    private int count;
    private Text countText;

    // Use this for initialization
    void Start()
    {
        SetCountText();
    }

    // Update is called once per frame
    void Update ()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        Vector3 direction = Vector3.zero;

        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                direction = -Vector3.left;
            }

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                direction = Vector3.left;
            }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                direction = Vector3.forward;
            }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                direction = -Vector3.forward;
            }

            rigidbody.AddTorque(direction * speed);

        }

        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            /*
            float threshold = 0.01f;
            float x = Input.acceleration.x;
            float y = Input.acceleration.y;

            if (x > threshold)
            {
                direction -= Vector3.forward;
            }

            if (x < -threshold)
            {
                direction += Vector3.forward;
            }

            if (y > threshold)
            {
                direction -= Vector3.left;
            }

            if (y < -threshold)
            {
                direction += Vector3.left;
            }

            direction = direction.normalized;

            rigidbody.AddTorque(direction * speed);
            */

            
            float x = Input.acceleration.x;
            float y = Input.acceleration.y;
            float threshold = 0.15f;

            if (x > threshold)
            {
                Debug.Log("x > " + threshold + " : x = " + x);
                direction = -Vector3.forward;
                rigidbody.AddTorque(direction * speed);
            }

            else if (x < threshold)
            {
                Debug.Log("x < " + threshold + " : x = " + x);
                direction = Vector3.forward;
                rigidbody.AddTorque(direction * speed);
            }

            if (y > threshold)
            {
                Debug.Log("y > " + threshold + " :y = " + y);
                direction = -Vector3.left;
                rigidbody.AddTorque(direction * speed);
            }

            else if (y < threshold)
            {
                Debug.Log("y < " + threshold + " :y = " + y);
                direction = Vector3.left;
                rigidbody.AddTorque(direction * speed);
            }

            //rigidbody.AddTorque(direction * speed);
            
            
            
            /*float x = Input.acceleration.x * gyroMultiplier;
            float y = Input.acceleration.y * gyroMultiplier;
            Vector3 movement = new Vector3(x, 0.0f, y);
            rigidbody.AddForce(movement * mobileSpeed);
            */
        }
        
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Crystal"))
        {
            SetCountText();
        }
    }

    public void SetCountText()
    {
        countText = FindObjectOfType<Text>();

        if (!SceneManager.GetActiveScene().name.Equals("Menu"))
        {
            count = LeaveCrystals();           
            countText.text = "Pozostało kryształów: " + count;
        }

        else
        {
            countText.text = "";
        }
    }

    int LeaveCrystals()
    {
        Crystal[] crystals = FindObjectsOfType<Crystal>();
        return crystals.Length;
    }
}
