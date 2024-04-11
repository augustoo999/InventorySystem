using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : Armor
{
    public int Hp;
    public FeetDTO FeetDTO;

    private void Start()
    {
        ManageDTO();
    }

    private void ManageDTO()
    {
        ItemName = FeetDTO.ItemName;
        ItemDescription = FeetDTO.ItemDescription;
        ItemLevel = FeetDTO.ItemLevel;
        Hp = FeetDTO.Hp;
        Mp = FeetDTO.Mp;
        ItemType = FeetDTO.ItemType;
    }

    public override int GetDamage()
    {
        return 0;
    }

    public override int GetHp()
    {
        return Hp;
    }

    public override ItemDTO GetScriptable()
    {
        return FeetDTO;
    }
}
