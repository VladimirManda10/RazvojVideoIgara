using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, IDamageable
{
    private float health = 100;
    public float Health { get { return health; } }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void setHealth(float health)
    {
        this.health = health;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }

}
