using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HealthPotion : Consumable, IPointerClickHandler
{
    private bool _CanDoubleClick;
    public int Hp;
    public HealthPotionDTO HealthPotionDTO;


    private void Start()
    {
        _CanDoubleClick = false;
        ManageDTO();
    }

    private void ManageDTO()
    {
        ItemName = HealthPotionDTO.ItemName;
        ItemDescription = HealthPotionDTO.ItemDescription;
        ItemLevel = HealthPotionDTO.ItemLevel;
        Hp = HealthPotionDTO.Hp;
        ItemType = HealthPotionDTO.ItemType;
    }

    public override int GetDamage()
    {
        return 0;
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
        return HealthPotionDTO;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_CanDoubleClick)
        {
            FindObjectOfType<EquipStats>().AddHpModifier(Hp);
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
}
