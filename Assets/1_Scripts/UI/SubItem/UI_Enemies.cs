using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Enemies : UI_Base
{
    public int HP{get;set;}
    public int AD {get;set;}
    public int DF {get;set;}
    public int SPD {get;set;}
    public int CRITICAL {get;set;}
    public override bool Init()
    {
        if (base.Init() == false)
            return false;
        SetInfo();
        return true;
    }

    void OnClickBtn()
    {
        ShowStat();
    }

     public void ShowStat()
    {
        TextMeshProUGUI TMP = this.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        TMP.text = "AD: " + AD + "\n";
        TMP.text += "DF: " + DF + "\n";
        TMP.text += "SPD: " + SPD + "\n";
        TMP.text += "CRI: " + CRITICAL + "\n";
    } 

    public void SetInfo()
    {
        HP = 13;
        AD = 2;
        DF = 3;
        SPD = 1;
        this.gameObject.BindEvent(OnClickBtn);
    }
}
