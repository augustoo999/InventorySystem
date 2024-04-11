using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Armor : Item
{
    public int Mp;

    public override int GetMp()
    {
        return Mp;
    }
}
