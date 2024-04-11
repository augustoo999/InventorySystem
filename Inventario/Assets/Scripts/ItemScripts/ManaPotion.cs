using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ManaPotion : Consumable, IPointerClickHandler
{
    private bool _CanDoubleClick;
    public int Mp;
    public ManaPotionDTO ManaPotionDTO;

    private void Start()
    {
        _CanDoubleClick = false;
        ManageDTO();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       if (_CanDoubleClick)
        {
            FindObjectOfType<EquipStats>().AddMpModifier(Mp);
            CancelInvoke();
            Destroy(gameObject);
        }
        else
        {
            _CanDoubleClick = true;
            Invoke(nameof(ResetDoubleClick), 3f);
        }
    }

    public void ResetDoubleClick()
    {
        _CanDoubleClick = false;
    }

    private void ManageDTO()
    {
        ItemName = ManaPotionDTO.ItemName;
        ItemDescription = ManaPotionDTO.ItemDescription;
        ItemLevel = ManaPotionDTO.ItemLevel;
        Mp = ManaPotionDTO.Mp;
        ItemType = ManaPotionDTO.ItemType;
    }

    public override int GetDamage()
    {
        return 0;
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
        return ManaPotionDTO;
    }
}
