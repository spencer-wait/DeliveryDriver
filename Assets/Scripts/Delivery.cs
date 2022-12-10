using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Better call the insurance company!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Picked up the package!");
        }

        if (other.tag == "Customer")
        {
            Debug.Log("Delivered the package!");
        }
        
    }
}
