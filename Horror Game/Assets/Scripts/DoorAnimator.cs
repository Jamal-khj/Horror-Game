using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    public Animator animator;
    public bool DoorOpen;
    public bool DoorClose;
    public KeyCode OpenDoor;

    void Start()
    {
        DoorOpen = false;
        DoorClose = false;
    }

    void Update()
    {
        animator.SetBool("Open", DoorOpen);
        animator.SetBool("Close", DoorClose);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
      //      if (Input.GetKeyUp(OpenDoor))
        //    {
                DoorOpen = true;
                DoorClose = false;
       //     }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           DoorClose = true;
           DoorOpen = false;
        }
    }
}