using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WEAPON;

public interface IAlly
{
    int HP {get;set;}
    int AD {get;set;}
    int DF {get;set;}
    int HEAT {get;set;}
    int CORE {get;set;}
    int SPD {get;set;}
    int CRITICAL {get;set;}
    string weapon {get;set;}
    int position {get;set;}
    public int Attack();
    public int Defend();
    public void ShowStat();
}