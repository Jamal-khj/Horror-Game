using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Setting Message when approaching object
    public GameObject InteractableObject;
    public KeyCode InteractKey;

    // Start is called before the first frame update
    void Start()
    {
        InteractableObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            InteractableObject.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            InteractableObject.SetActive(false);
        }
    }
}