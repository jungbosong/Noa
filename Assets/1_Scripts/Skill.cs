using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skill : MonoBehaviour
{
    public List<Button> enemies = new List<Button>();
    int _enemyIdx;
    int _AD;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClicked);
    }

    void OnClicked()
    {
        switch(_enemyIdx)
        {
            case 0:{
                enemies[_enemyIdx].gameObject.GetComponentInChildren<Anchor>().AD -= _AD;
                enemies[_enemyIdx].gameObject.GetComponentInChildren<Anchor>().ShowStat();
                break;
            }
            case 1:{ 
                enemies[_enemyIdx].gameObject.GetComponentInChildren<Netting>().AD -= _AD;
                enemies[_enemyIdx].gameObject.GetComponentInChildren<Netting>().ShowStat();
                break;
            }
            case 2:{
                enemies[_enemyIdx].gameObject.GetComponentInChildren<CannonBoat>().AD -= _AD;
                enemies[_enemyIdx].gameObject.GetComponentInChildren<CannonBoat>().ShowStat();
                break;
            }
            case 3:{
                enemies[_enemyIdx].gameObject.GetComponentInChildren<SubmarineMiner>().AD -= _AD;
                enemies[_enemyIdx].gameObject.GetComponentInChildren<SubmarineMiner>().ShowStat();
                break;
            }
        }
    }

    public void SetAD(int AD)
    {
        _AD = AD;
    }

    public void SetEnemy(int enemyIdx)
    {
        _enemyIdx = enemyIdx;
    }


}
