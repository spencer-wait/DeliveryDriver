using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        // assign input to steering and driving
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float drivingSpeed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // perform more realistic car movements
        if (drivingSpeed == 0) { transform.Rotate(0, 0, 0); } // Don't allow turning when car is stopped
        else if (drivingSpeed < 0) { transform.Rotate(0, 0, steerAmount); }  // opposite steer direction when reversing the car to simulate reality
        else { transform.Rotate(0, 0, -steerAmount); }  // rotate car based on negative horizontal axis when moving forward

        transform.Translate(0, drivingSpeed, 0);    // move car forward/back based on vertical axis
        
    }
}
