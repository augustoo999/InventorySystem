using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class EquipStats : MonoBehaviour
{
    public TextMeshProUGUI HpTxt;
    public TextMeshProUGUI MpTxt;
    public TextMeshProUGUI DamageTxt;


    private int _currentHp;
    private int _currentMp;
    private int _currentDamage;

    private int _HpModifier = 0;
    private int _MpModifier = 0;
    private int _DamageModifier = 0;


    private void Update()
    {
        var EquippedItems = GetComponentsInChildren<Item>().ToList();

        _currentHp = 0 + _HpModifier;
        _currentDamage = 0 + _DamageModifier;
        _currentMp = 0 + _MpModifier;

        foreach (var item in EquippedItems)
        {
            _currentDamage += item.GetDamage();
            _currentHp += item.GetHp();
            _currentMp += item.GetMp();
        }

        HpTxt.text = $"Hp: {_currentHp}";
        DamageTxt.text = $"Damage: {_currentDamage}";
        MpTxt.text = $"Mana: {_currentMp}";
    }

    public void AddHpModifier(int quantity)
    {
        _HpModifier += quantity;
    }

    public void AddMpModifier(int quantity) 
    {  
        _MpModifier += quantity;
    }

    public void AddDamageModifier(int quantity)
    {
        _DamageModifier += quantity;
    }
}
