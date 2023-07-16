using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyManager
{
    public List<Ally> allies{get;set;}
    public List<bool> isSet{get;set;}

    public void Init()
    {
        allies = new List<Ally>();
        isSet = new List<bool>();
        for(int i = 0; i < 3; i++)
        {
            allies.Add(new Ally());
            isSet.Add(false);
        }
    }
}
