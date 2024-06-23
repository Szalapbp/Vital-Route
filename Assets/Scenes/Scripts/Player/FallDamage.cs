using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{

    //This code currently does not work with the map that I am using.
    //I believe the issue is due to the map being terrain rather than planes or 3d objects.
    //I plan to do some updating on the raycast configuration in the future to resolve the issue.
    public float fallDamageMultiplier = 10f;
    private float fallTime = 0f;
    private bool isFalling = false;
    private Rigidbody rb;
    private PlayerHealth playerHealth;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerHealth = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (rb.velocity.y < -0.1f)
        {

            if (!isFalling)
            {
                isFalling = true;
                fallTime = 0f;
            }
            fallTime += Time.deltaTime;
        }
        else if (isFalling && rb.velocity.y >= -0.1f)
        {
            isFalling = false;
            if (fallTime > 1f)
            {
                ApplyFallDamage(fallTime);
            }
            fallTime = 0f;
        }

      
    }
    void ApplyFallDamage(float fallDuration)
    {
        float damage = fallDuration * fallDamageMultiplier;
        playerHealth.TakeDamage(damage);
    }
}
