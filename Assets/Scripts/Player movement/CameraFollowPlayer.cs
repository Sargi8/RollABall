using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer: MonoBehaviour
{
    
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;
    
    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
        
    }
}
