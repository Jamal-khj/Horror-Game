using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public GameObject player;
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
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        

        if(distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, Enemyspeed * Time.deltaTime); // moves this object towards the player object
            transform.rotation = Quaternion.Euler(Vector3.forward * angle); // rotates this object towards player object
            ismoving = true; 
        }

        else if (distance > distanceBetween)

            {
                ismoving = false;
            }


    }
}
