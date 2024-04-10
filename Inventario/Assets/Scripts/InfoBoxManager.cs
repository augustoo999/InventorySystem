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

    private ItemScriptable _ItemScriptable;
    private int _Mp;
    private int _Hp;
    private int _Damage;

    private void Start()
    {
        InfoBoxGameObject.SetActive(false);
    }
}
