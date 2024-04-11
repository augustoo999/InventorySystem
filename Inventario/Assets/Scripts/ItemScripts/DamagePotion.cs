using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DamagePotion : Consumable, IPointerClickHandler
{
    private bool _CanDoubleClick;
    public int Damage;
    public DamagePotionDTO DamagePotionDTO;

    private void Start()
    {
        _CanDoubleClick = false;
        ManageDTO();
    }

    private void ManageDTO()
    {
        ItemName = DamagePotionDTO.ItemName;
        ItemDescription = DamagePotionDTO.ItemDescription;
        ItemLevel = DamagePotionDTO.ItemLevel;
        Damage = DamagePotionDTO.Damage;
        ItemType = DamagePotionDTO.ItemType;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (_CanDoubleClick)
        {
            FindObjectOfType<EquipStats>().AddDamageModifier(Damage);
            CancelInvoke();
            Destroy(gameObject);
        }

        else
        {
            _CanDoubleClick = true;
            Invoke(nameof(ResetDoubleClick), 3f);
        }
    }

    private void ResetDoubleClick()
    {
        _CanDoubleClick = false;
    }

    public override int GetDamage()
    {
        return Damage;
    }

    public override int GetHp()
    {
        return 0;
    }

    public override int GetMp()
    {
        return 0;
    }

    public override ItemDTO GetScriptable()
    {
        return DamagePotionDTO;
    }

    
}
