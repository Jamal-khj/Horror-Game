using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int Health;

    [SerializeField] FloatingHealthBar healthBar;

    private void Awake()
    {
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    void Start()
    {
        Health = maxHealth;
        healthBar.UpdateHealthBar(Health, maxHealth);
    }

    void Update()
    {
        
    }

    public void TakeDamage(int amount) // int amount for how much damage to take
    {
        Health -= amount;
        healthBar.UpdateHealthBar(Health, maxHealth);
        if(Health <= 0 )
        {
            Destroy(gameObject);
        }

    }
}
