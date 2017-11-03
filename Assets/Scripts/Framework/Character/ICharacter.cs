using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter {

    float Health { get; set; }
    float MaxHealth { get; set; }
    
    void TakeDamage(ICharacter attacker, float dmgAmmout);
}
