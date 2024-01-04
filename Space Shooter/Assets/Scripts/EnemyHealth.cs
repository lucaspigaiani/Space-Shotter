using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3; // Adjust the maximum health as needed
    private int currentHealth;
    private SpriteRenderer enemyShip;

    void Start()
    {
        enemyShip = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            TakeDamage(1); // Reduce health by 1 when hit by a bullet
        }

        if (other.CompareTag("Player"))
        {
            TakeDamage(1); // Reduce health by 1 when hit by the player
        }
    }

    void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        switch (currentHealth)
        {
            case 2:
                enemyShip.color = Color.green;
                break;
            case 1:
                enemyShip.color = Color.red;
                break;
            default:
                break;
        }
        if (currentHealth <= 0)
        {
            DestroyEnemy(); // Call the method to handle enemy destruction
        }
    }

    void DestroyEnemy()
    {
        // Implement your destroy logic here, e.g., play an explosion animation, spawn particles, etc.
        // Then destroy the enemy GameObject
        Destroy(gameObject);
    }
}
