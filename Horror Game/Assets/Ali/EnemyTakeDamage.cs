using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    // this script should be assigned for a bullet or something like that

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy1")
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(1); // EnemyHealth is the other script and TakeDamage is the function its accessing, in brackets() set the damage amount
        }
    }
    
}
