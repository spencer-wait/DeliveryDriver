using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour

{
    bool hasPackage;
    [SerializeField] GameObject packageInCar;
    [SerializeField] Color32 hasPackageColor = new Color32();
    [SerializeField] Color32 noPackageColor = new Color32();
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        packageInCar.gameObject.SetActive(false);   // make package in car not appear to begin with
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("Better call the insurance company!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Picked up the package!");
            hasPackage = true;
            packageInCar.gameObject.SetActive(true);    // make package in car visible
            Destroy(other.gameObject);
            // spriteRenderer.color = hasPackageColor;
        }
        else if (other.tag == "Package" && hasPackage)
        {
            Debug.Log("You must deliver the package you're holding before picking up another.");
        }

        if (other.tag == "Customer" && !hasPackage)
        {
            Debug.Log("You must pick up a package first to be delivered.");
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("You delivered the package successfully!");
            packageInCar.gameObject.SetActive(false);    // make package in car disappear
            hasPackage = false;
            // spriteRenderer.color = noPackageColor;
        }
        
    }
}
