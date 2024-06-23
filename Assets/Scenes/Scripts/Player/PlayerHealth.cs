using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    private float currentHealth;

    public delegate void OnHealthChanged(float currentHealth);
    public event OnHealthChanged HealthChanged;

   

    private void Start()
    {
        currentHealth = maxHealth;
        HealthChanged?.Invoke(currentHealth);
    }

    public void TakeDamage(float amount)
    {
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }


        
        if(currentHealth <= 0f)
        {
            Die();
        }
        HealthChanged?.Invoke(currentHealth);

        void Die()
        {
            Debug.Log("Died");
        }
    }
}
