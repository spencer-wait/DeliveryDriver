using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script to sink player's car and restart the game upon driving into the lake
public class Drown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FIX ME: Placeholder for sinking car and restarting game
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You have drowned.");
    }
}
