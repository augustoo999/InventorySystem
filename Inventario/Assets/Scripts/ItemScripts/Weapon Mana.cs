using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMana : Weapon
{
    public int Mp;
    public WeaponManaDTO WeaponManaDTO;

    private void Start()
    {
        ManageDTO();
    }

    private void ManageDTO()
    {
        ItemName = WeaponManaDTO.ItemName;
        ItemDescription = WeaponManaDTO.ItemDescription;
        ItemLevel = WeaponManaDTO.ItemLevel;
        Mp = WeaponManaDTO.Mp;
        ItemType = WeaponManaDTO.ItemType;
    }

    public override int GetHp()
    {
        return 0;
    }

    public override int GetMp()
    {
        return Mp;
    }

    public override ItemDTO GetScriptable()
    {
        return WeaponManaDTO;
    }
}
