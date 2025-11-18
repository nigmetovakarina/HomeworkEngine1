using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HealthComponent : IHealthComponent
{
    private float health = 25;
    public float maxHealth = 100;
    public float Health
    {
        get
        { return health; }

        private set
        {
            health = Mathf.Clamp(value, min: 0, MaxHealth);
            if (health == 0)
                SetDeath();
        }
    }

    public float MaxHealth => maxHealth;

    float IHealthComponent.Health { get => Health; set => Health = value; }
    float IHealthComponent.MaxHealth { get => MaxHealth; set => throw new System.NotImplementedException(); }

    public void SetDamage(int damage)
    {
        Health -= damage;
    }

    private void SetDeath() {
        Debug.LogError("слеп");
    }
}