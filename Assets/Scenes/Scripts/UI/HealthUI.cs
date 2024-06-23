using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text healthText;
    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.HealthChanged += UpdateHealthUI;
          
            UpdateHealthUI(playerHealth.maxHealth);
        }
    }

    void UpdateHealthUI(float currentHealth)
    {
        healthText.text = "Health: " + currentHealth.ToString("F0");
    }

    private void OnDestroy()
    {
        if (playerHealth != null)
        {
            playerHealth.HealthChanged -= UpdateHealthUI;
        }
    }
}
