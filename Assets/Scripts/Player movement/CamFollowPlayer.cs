using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer: MonoBehaviour
{
    
    public Transform player;
    public Vector3 offset;
    
    void Update()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
        
    }
}
