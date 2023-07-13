using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WEAPON;

namespace WEAPON{
    enum WEAPONS
    {
        Axe,
        Dugfoot,
        TwinHammer,
        Cannon,
        MachineGun,
        Crossbow,
        Grenade,
        SniperGun,
        Cross,
    }
    public class Weapon {
        
        public int type {get;set;}
        
        public T StringToEnum<T>(string e)
        {
            return (T)Enum.Parse(typeof(T), e);
        }
        public Weapon(string weapon)
        {
            WEAPONS weapons = StringToEnum<WEAPONS>(weapon);
            type = (int)weapons;
        }   
        public T IntToEnum<T>(int e)
        {
            return (T)(object)e;
        }
        public string GetWeaponType()
        {
            return IntToEnum<WEAPONS>(type).ToString();
        }
    }
}
public class Ally : IAlly
{
    public int HP {get;set;}
    public int AD {get;set;}
    public int DF {get;set;}
    public int HEAT {get;set;}
    public int CORE {get;set;}
    public int SPD {get;set;}
    public int CRITICAL {get;set;}
    public string weapon {get;set;}
    public int position {get;set;}
    public int Attack()
    {
        return AD;
    }
    public int Defend()
    {
        return DF;
    }
    public void ShowStat()
    {

    }
}
