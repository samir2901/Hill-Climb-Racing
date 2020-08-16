using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D frontTireRb, backTireRb, carRb;
    public float speed = 15f;
    public float carTorque = 10f;
    float horizontalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");        
    }
    private void FixedUpdate()
    {
        backTireRb.AddTorque(-horizontalInput * speed * Time.fixedDeltaTime);
        backTireRb.AddTorque(-horizontalInput * speed * Time.fixedDeltaTime);
        carRb.AddTorque(-horizontalInput * carTorque * Time.fixedDeltaTime);
    }
}
