using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;

    // LateUpdate used so that camera movement always happens after car position changes each time
    void LateUpdate()
    {
        transform.position = objectToFollow.transform.position + new Vector3(0,0,-10);
        
    }
}
