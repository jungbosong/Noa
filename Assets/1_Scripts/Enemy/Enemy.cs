using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Enemy
{
    int HP {get;set;}
    int AD {get;set;}
    int DF {get;set;}
    int SPD {get;set;}
    int CRITICAL {get;set;}

    public int Attack();
    public int Defend();
    public void ShowStat();
}