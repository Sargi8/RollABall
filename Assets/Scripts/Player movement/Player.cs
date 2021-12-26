using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField]private float speed = 20f;

    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void MoveController()
    {
        float moveVertical = Input.GetAxis("Vertical") * speed;
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;

        Vector3 movement = new Vector3(-moveHorizontal, 0, -moveVertical) * Time.deltaTime;

        rigidbody.AddForce(movement * speed, ForceMode.Acceleration);
    }


}
