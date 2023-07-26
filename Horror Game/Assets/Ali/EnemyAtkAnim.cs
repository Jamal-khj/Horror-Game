using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtkAnim : MonoBehaviour
{
    public Animator animator;

    public bool isAttacking;


     void Start()
    {
        isAttacking = false;
    }

    void Update()
    {
        animator.SetBool("Attack", isAttacking);

    }

    void OnCollisionEnter2D(Collision2D collision)
     {

         if(collision.collider.gameObject.tag == "Player")
         {
          isAttacking = true;
         }

         else 
         {
          isAttacking = false;
         }

     }
}
