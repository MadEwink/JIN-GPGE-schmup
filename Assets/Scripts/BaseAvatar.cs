using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAvatar : MonoBehaviour
{
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float maxHealth;
    private float health;

    public float MaxSpeed
    {
        get { return this.maxSpeed; }
        private set { this.maxSpeed = value; }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
            Die();
    }

    public abstract void Die();
}
