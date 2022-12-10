using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour

{
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Better call the insurance company!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "Package") && (hasPackage == false))
        {
            Debug.Log("Picked up the package!");
            hasPackage = true;
        }
        else if ((other.tag == "Package") && (hasPackage == true))
        {
            Debug.Log("You must deliver the package you're holding before picking up another.");
        }

        if ((other.tag == "Customer") && (hasPackage == false))
        {
            Debug.Log("You must pick up a package first to be delivered.");
        }
        else if ((other.tag == "Customer") && (hasPackage == true))
        {
            Debug.Log("You delivered the package successfully!");
            hasPackage = false;
        }
        
    }
}
