using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Item 
{
    public int Damage;

    public override int GetDamage()
    {
        return Damage;
    }
}
