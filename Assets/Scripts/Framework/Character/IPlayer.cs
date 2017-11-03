using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer : ICharacter
{
    int Lives { get; set; }
    int MaxLives { get; set; }
}
