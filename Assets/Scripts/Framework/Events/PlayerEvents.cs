using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageEventArgs : EventArgs
{
    public float DamageAmount { get; set; }
    public float MaxHealth { get; set; }

    public TakeDamageEventArgs()
    {

    }

    public TakeDamageEventArgs(float damageAmount, float maxHealth)
    {
        MaxHealth = maxHealth;
        DamageAmount = damageAmount;
    }
}

public class HealthChangedEventArgs : EventArgs
{
    public float Health { get; set; }
    public float MaxHealth { get; set; }

    public HealthChangedEventArgs()
    {

    }

    public HealthChangedEventArgs(float health, float maxHealth)
    {
        Health = health;
        MaxHealth = maxHealth;
    }
}
public class LivesChangedEventArgs : EventArgs
{
    public float Lives { get; set; }
    public float MaxLives { get; set; }

    public LivesChangedEventArgs()
    {

    }

    public LivesChangedEventArgs(float lives, float maxLives)
    {
        Lives = lives;
        MaxLives = maxLives;
    }
}