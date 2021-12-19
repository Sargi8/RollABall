using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected GameObject[] waipoints;
    private int currentTarget = 0;
    private float rotationSpeed = 3;
    [SerializeField] protected float speed;
    private float waypointRadius = 1f;




    public void EnemyMove()
    {
        if (Vector3.Distance(waipoints[currentTarget].transform.position, transform.position) < waypointRadius)
        {
            currentTarget++;
            if (currentTarget >= waipoints.Length)
            {
                currentTarget = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waipoints[currentTarget].transform.position, speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, rotationSpeed, 0));
    }

    
    
    public void EnemyTrigger(Collider other )
    {
        if(other != null)
        {
            if (other.tag == "Player")
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene("SampleScene");
            }
        }
        
    }
    
}
