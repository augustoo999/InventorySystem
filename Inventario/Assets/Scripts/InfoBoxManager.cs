using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoBoxManager : MonoBehaviour
{
    public GameObject InfoBoxGameObject;
    public TextMeshProUGUI NameTxt;
    public TextMeshProUGUI DescriptionTxt;
    public TextMeshProUGUI LevelTxt;
    public TextMeshProUGUI StatsBox;

    private ItemDTO _ItemScriptable;
    private int _Mp;
    private int _Hp;
    private int _Damage;

    private void Start()
    {
        InfoBoxGameObject.SetActive(false);
    }

    public void DesactivateInfoBox()
    {
        InfoBoxGameObject.SetActive(false);
    }

    private void Update()
    {
        if (!_ItemScriptable) return;
        NameTxt.text = _ItemScriptable.ItemName;
        DescriptionTxt.text = _ItemScriptable.ItemDescription;
        LevelTxt.text = $"{ _ItemScriptable.ItemLevel}";
        StatsBox.text = $"Damage +{_Damage}, MANA +{_Mp}, HEALTH +{_Hp}";
    }

    public void SetScriptable(ItemDTO itemScriptable, int dmg, int mana, int health)
    {
        InfoBoxGameObject.SetActive(true);
        _Damage = dmg;
        _Mp = mana;
        _Hp = health;
        _ItemScriptable = itemScriptable;
    }
}
