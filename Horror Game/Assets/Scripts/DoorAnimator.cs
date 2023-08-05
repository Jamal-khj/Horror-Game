using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    public Animator animator;
    public bool DoorOpen;
   // public bool DoorClose;

    void Start()
    {
        DoorOpen = false;
     //   DoorClose = false;
    }

    void Update()
    {
        animator.SetBool("Open", DoorOpen);
      //  animator.SetBool("Close", DoorClose);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            DoorOpen = true;
         //   DoorClose = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
          //  DoorClose = true;
            DoorOpen = false;
        }
    }
}