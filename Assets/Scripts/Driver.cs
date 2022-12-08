using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set steering and driving to input axes
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float drivingSpeed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        if (drivingSpeed == 0) { transform.Rotate(0, 0, 0); } // Don't allow turning when car is stopped
        else if (drivingSpeed < 0) { transform.Rotate(0, 0, steerAmount); }  // opposite steer direction when reversing the car to simulate reality
        else { transform.Rotate(0, 0, -steerAmount); }  // rotate car based on negative horizontal axis when moving forward

        transform.Translate(0, drivingSpeed, 0);    // move car forward/back based on vertical axis
    }
}
