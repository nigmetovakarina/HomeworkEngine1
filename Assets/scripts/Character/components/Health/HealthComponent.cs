using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : IHealthComponent
{
    private float health = 25;
    public float maxHealth = 100;

    {
        get
        { return health; }
      private set {
    health = Mathf.Clamp(value, min: 0, MaxHealth);
    if (health == 0)
        SetDeath(); }
        }
    }
    public float MaxHealth => maxHealth;

public void SetDamage(int damage)
    {
    Health -= damage;
    }
}
