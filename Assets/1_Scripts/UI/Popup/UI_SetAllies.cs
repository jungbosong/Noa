using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_SetAllies : UI_Popup
{
    public override bool Init()
    {
        if (base.Init() == false)
            return false;
        return true;
    }
    /*int characterNum = 0;
    int position = 0;
    bool isDone = false;
    string[][] weapons = {
        new string[] {"Grenade", "SniperGun", "Cross"},
        new string[] {"Cannon", "MachineGun", "Crossbow"},
        new string[] {"Axe", "Dugfoot", "TwinHammer"},
    };
    string[][] kr_weapons = {
        new string[] {"유탄", "저격총", "십자가"},
        new string[] {"대포", "기관총", "크로스보우"},
        new string[] {"도끼", "덕풋", "쌍망치"},
    };
    enum GameObjects
    {
        BGImage,
        TitleTMP,
        CharacterPanel,
        PositionPanel,
        WeaponPanel,
        DicisionPanel,
        DoneButton,
    }

    enum Characters
    {
        A,
        B,
        C
    }

    enum Position
    {
        Support,
        Attack,
        Defend,
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObject(typeof(GameObjects));

        GetObject((int)GameObjects.TitleTMP).gameObject.GetComponent<TextMeshProUGUI>().text = "함께 싸울 아군을 지정하세요.";
        GetObject((int)GameObjects.DoneButton).gameObject.BindEvent(OnClickedDoneBtn);
        GetObject((int)GameObjects.DoneButton).gameObject.SetActive(false);

        int i = 0;
        foreach (Transform child in GetObject((int)GameObjects.CharacterPanel).transform)
        {
            child.gameObject.BindEvent(() => OnClickedCharacterBtn(i++));
            if(i>=1) child.gameObject.SetActive(false);
        }

        i = 0;
        foreach (Transform child in GetObject((int)GameObjects.PositionPanel).transform)
        {
            child.gameObject.BindEvent(() => OnClickedPositionBtn(i++));
            child.gameObject.SetActive(false);
        }

        i = 0;
        foreach (Transform child in GetObject((int)GameObjects.WeaponPanel).transform)
        {
            child.gameObject.BindEvent(() => OnClickedWeaponBtn(i++));
            child.gameObject.SetActive(false);
        }

        GetComponent<Canvas>().sortingOrder = 10;

        return true;
    }

    void OnClickedCharacterBtn(int idx)
    {
        if(Managers.Ally.isSet[idx]) Managers.Ally.isSet[idx] = !Managers.Ally.isSet[idx];
        characterNum = idx;
        GetObject((int)GameObjects.TitleTMP).gameObject.GetComponent<TextMeshProUGUI>().text = "함께 싸울 아군" + IntToEnum<Characters>(idx).ToString() + "의 위치를 지정하세요.";
        foreach (Transform child in GetObject((int)GameObjects.PositionPanel).transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    void OnClickedPositionBtn(int idx)
    {
        GetObject((int)GameObjects.TitleTMP).gameObject.GetComponent<TextMeshProUGUI>().text = "함께 싸울 아군"+ IntToEnum<Characters>(characterNum).ToString() +"의 무기를 지정하세요.";
        Managers.Ally.allies[characterNum].position = idx;
        position = idx;
        foreach (Transform child in GetObject((int)GameObjects.WeaponPanel).transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    void OnClickedWeaponBtn(int idx)
    {
        Managers.Ally.allies[characterNum].weapon = weapons[characterNum][position];
        Managers.Ally.isSet[characterNum] = true;
        GetObject((int)GameObjects.DoneButton).gameObject.SetActive(true);
        SetDicisionPanel(idx);

        foreach (Transform child in GetObject((int)GameObjects.PositionPanel).transform)
        {
            child.gameObject.SetActive(false);
        }
        foreach (Transform child in GetObject((int)GameObjects.WeaponPanel).transform)
        {
            child.gameObject.SetActive(false);
        }

        for(int i = 0; i < 3; i++)
        {
            if(Managers.Ally.isSet[i]) continue;
            isDone = true;
        }
        if(isDone)
        {
            GetObject((int)GameObjects.TitleTMP).gameObject.GetComponent<TextMeshProUGUI>().text = "함께 싸울 아군 정보를 확인 후 시작하세요\n 혹은 바꾸고 싶은 아군을 선택하세요.";
            return;
        }
        GetObject((int)GameObjects.TitleTMP).gameObject.GetComponent<TextMeshProUGUI>().text = "함께 싸울 아군을 지정하세요.";
    }

    void OnClickedDoneBtn()
    {
        if(isDone)
        {
           ClosePopupUI();
        }
    }

    void SetDicisionPanel(int idx)
    {
        int i = 0;
        string info = "캐릭터: " + IntToEnum<Characters>(characterNum).ToString() + "\n위치: "  + IntToEnum<Position>(position).ToString() + "\n무기: " + weapons[characterNum][position];
        foreach (Transform child in GetObject((int)GameObjects.DicisionPanel).transform)
        {
            if(i++ != idx) continue;
            child.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = info;
        }
    }

    public T IntToEnum<T>(int e)
    {
        return (T)(object)e;
    }*/
}
