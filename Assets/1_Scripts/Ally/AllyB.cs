using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using WEAPON;

public class AllyB : MonoBehaviour, IAlly
{
    public int HP {get;set;}
    public int AD {get;set;}
    public int DF {get;set;}
    public int HEAT {get;set;}
    public int CORE {get;set;}
    public int SPD {get;set;}
    public int CRITICAL {get;set;}
    public string weapon {get;set;}
    public int position{get;set;}
    public Button SkillBtn;
    public int Attack()
    {
        Debug.Log("Ally B " + weapon + " AD: " + AD);
        return AD;
    }
    public int Defend()
    {
        Debug.Log("Ally B " + weapon + " DF: " + DF);
        return DF;
    }
    public void ShowStat()
    {
        TextMeshProUGUI TMP = this.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        TMP.text = "AD: " + AD + "\n";
        TMP.text += "DF: " + DF + "\n";
        TMP.text += "SPD: " + SPD + "\n";
        TMP.text += "CRI: " + CRITICAL + "\n";
        TMP.text += "HEAT: " + HEAT + "\n";
        TMP.text += "weapon: " + weapon + "\n";
        TMP.text += "weapon: " + weapon + "\n";
    }  

    void Start()
    {
        Init();
        this.gameObject.GetComponent<Button>().onClick.AddListener(OnClicked);
        SkillBtn = SkillBtn.GetComponent<Button>();
        ShowStat();
    } 

    private void Init()
    {
        HP = 32;
        AD = 8; 
        DF = 0;
        SPD = 9;
        CRITICAL = 0;
        CORE = 2;
        HEAT = 3;
        weapon = "MachineGun";
    }
    public void OnClicked()
    {
        SkillBtn.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = AD.ToString();
        SkillBtn.gameObject.GetComponent<Skill>().SetAD(AD);
        SkillBtn.gameObject.GetComponent<Skill>().SetEnemy(1);
    }
}
