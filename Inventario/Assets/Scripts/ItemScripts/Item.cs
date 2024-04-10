using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public ItemType ItemType;
    public string ItemName;
    public string ItemDescription;
    public int ItemLevel;

    public abstract int GetDamage();

    public abstract int GetHp();

    public abstract int GetMp();

    public abstract ItemScriptable GetScriptable();
}
