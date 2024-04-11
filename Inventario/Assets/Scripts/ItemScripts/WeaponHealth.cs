using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHealth : Weapon
{
    public int Hp;
    public WeaponHealthDTO WeaponHealthDTO;

    private void Start()
    {
        ManageDTO();
    }

    private void ManageDTO()
    {
        ItemName = WeaponHealthDTO.ItemName;
        ItemDescription = WeaponHealthDTO.ItemDescription;
        ItemLevel = WeaponHealthDTO.ItemLevel;
        Hp = WeaponHealthDTO.Hp;
        ItemType = WeaponHealthDTO.ItemType;
    }

    public override int GetHp()
    {
        return Hp;
    }

    public override int GetMp()
    {
        return 0;
    }

    public override ItemDTO GetScriptable()
    {
        return WeaponHealthDTO;
    }
}
