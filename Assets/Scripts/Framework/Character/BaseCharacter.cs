using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, ICharacter
{
    public virtual float Health
    {
        get; set;
    }

    public virtual float MaxHealth
    {
        get; set;
    }

    private void Start()
    {
        OnStart();
    }

    protected virtual void OnStart()
    {
        Health = MaxHealth;
    }

    public virtual void TakeDamage(ICharacter attacker, float dmgAmmout)
    {
        Health = Mathf.Max(Health - dmgAmmout, 0);

        if (Health == 0)
        {
            OnKilledBy(attacker);
        }
    }

    protected virtual void OnKilledBy(ICharacter attacker)
    {

    }
}
