using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using WEAPON;

public class UI_Allies : UI_Base
{
    public int HP {get;set;}
    public int AD {get;set;}
    public int DF {get;set;}
    public int HEAT {get;set;}
    public int CORE {get;set;}
    public int SPD {get;set;}
    public int CRITICAL {get;set;}
    public Weapon weapon {get;set;}
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
        TMP.text += "HEAT: " + HEAT + "\n";
        TMP.text += "weapon: " + weapon.GetWeaponType() + "\n";
    } 

    public void SetInfo()
    {
        HP = 32;
        AD = 4; 
        DF = 4;
        SPD = 6;
        CRITICAL = 0;
        CORE = 2;
        HEAT = 4;
        weapon = new Weapon("Axe");
        this.gameObject.BindEvent(OnClickBtn);
    }
}