using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : Armor
{
    public int Hp;
    public BodyDTO bodyDTO;


    private void Start()
    {
        ManageDTO();
    }

    private void ManageDTO()
    {
        ItemName = bodyDTO.ItemName;
        ItemDescription = bodyDTO.ItemDescription;
        ItemLevel = bodyDTO.ItemLevel;
        Hp = bodyDTO.Hp;
        Mp = bodyDTO.Mp;
        ItemType = bodyDTO.ItemType;
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
        return bodyDTO;
    }
}
