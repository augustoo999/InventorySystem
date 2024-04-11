using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : Armor
{
    public int Damage;
    public HeadDTO HeadDTO;

    private void Start()
    {
        ManageDTO();
    }

    private void ManageDTO()
    {
        ItemName = HeadDTO.ItemName;
        ItemDescription = HeadDTO.ItemDescription;
        ItemLevel = HeadDTO.ItemLevel;
        Damage = HeadDTO.Damage;
        Mp = HeadDTO.Mp;
        ItemType = HeadDTO.ItemType;
    }

    public override int GetDamage()
    {
        return Damage;
    }

    public override int GetHp()
    {
        return 0;
    }

    public override ItemDTO GetScriptable()
    {
        return HeadDTO;
    }
}
