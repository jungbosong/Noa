using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Netting : MonoBehaviour
{
    public int HP{get;set;}
    public int AD {get;set;}
    public int DF {get;set;}
    public int SPD {get;set;}
    public int CRITICAL {get;set;}

    public int Attack()
    {
        Debug.Log("Netting Attack: " + AD);
        return AD;
    }

    public int Defend()
    {
        Debug.Log("Netting Defend: " + DF);
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
        AD = 5;
        DF = 0;
        SPD = 8;
    }

    void Start()
    {
        Init();
        ShowStat();
    }
}
