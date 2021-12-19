using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBallEnemy : Enemy
{

    

    private void Update()
    {
        EnemyMove();
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyTrigger(other);
    }
}
