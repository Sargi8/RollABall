using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float speed = 10f;
    

   
    private void Update()
    {
        MoveController();
    }

   

    void MoveController()
    {
        float moveVertical = Input.GetAxis("Vertical") * speed;
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;

        Vector3 movement = new Vector3(-moveHorizontal, 0, -moveVertical) * Time.deltaTime;

        rigidbody.AddForce(movement * speed, ForceMode.Acceleration);
    }


    
}
