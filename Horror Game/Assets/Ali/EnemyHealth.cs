using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        
    }

    public void TakeDamage(int amount) // int amount for how much damage to take
    {
        currentHealth -= amount;
        if(currentHealth <= 0 )
        {
            Destroy(gameObject);
        }

    }
}
