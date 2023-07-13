using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Anchor : MonoBehaviour, Enemy
{
    public int HP{get;set;}
    public int AD {get;set;}
    public int DF {get;set;}
    public int SPD {get;set;}
    public int CRITICAL {get;set;}

    public int Attack()
    {
        Debug.Log("Anchor Attack: " + AD);
        return AD;
    }

    public int Defend()
    {
        Debug.Log("Anchor Defend: " + DF);
        return DF;
    }
    public void ShowStat()
    {
        TextMeshProUGUI TMP = this.gameObject.GetComponentInChildren<TextMeshProUGUI>();
         TMP.text = "AD: " + AD + "\n";
        TMP.text += "DF: " + DF + "\n";
        TMP.text += "SPD: " + SPD + "\n";
        TMP.text += "CRI: " + CRITICAL + "\n";
    }
    private void Init()
    {
        HP = 13;
        AD = 2;
        DF = 3;
        SPD = 1;
    }

    void Start()
    {
        Init();
        ShowStat();
    }
}
