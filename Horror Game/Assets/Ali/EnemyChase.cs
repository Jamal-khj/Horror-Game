using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyStart;
    public float Enemyspeed;
    public float distanceBetween;

    public bool ismoving;

    public Animator animator;

    private float distance;

    
    void Start()
    {
        ismoving = false;
    }

    
    void Update()
    {
        animator.SetBool("Speeed", ismoving);


        distance = Vector2.Distance(transform.position, player.transform.position); // calculates the distance between gameobject player and the object this script is assigned to
        Vector2 direction = player.transform.position - transform.position;
        Vector2 direction2 = enemyStart.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //for enemy to player
        float angle2 = Mathf.Atan2(direction2.y, direction2.x) * Mathf.Rad2Deg; // for enemy to enemy start point

        

        if(distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, Enemyspeed * Time.deltaTime); // moves this object towards the player object
            transform.rotation = Quaternion.Euler(Vector3.forward * angle); // rotates this object towards player object
            ismoving = true; 
        }

        else if (distance > distanceBetween)

            {
                transform.position = Vector2.MoveTowards(this.transform.position, enemyStart.transform.position, Enemyspeed * Time.deltaTime); // moves this object towards the player object
                transform.rotation = Quaternion.Euler(Vector3.forward * angle2); // rotates this enemy towards enemy start position
            
                ismoving = false;
            }


    }
}
