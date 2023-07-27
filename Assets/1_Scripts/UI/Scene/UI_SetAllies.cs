using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_SetAllies : UI_Scene
{
    int characterNum = 0;
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

    enum Images
    {
        BGImage,
    }

    enum Texts
    {
        TitleTMP,
    }
    enum Buttons
    {
        DoneButton,
    }

    enum GameObjects
    {    
        CharacterPanel,
        //PositionPanel,
        WeaponPanel,
        DicisionPanel,
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

    void Start()
    {
        Init();
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;
        
        BindImage(typeof(Images));
        BindText(typeof(Texts));
        BindButton(typeof(Buttons));
        BindObject(typeof(GameObjects));

        GetText((int)Texts.TitleTMP).text = "함께 싸울 아군을 지정하세요.";
        GetButton((int)Buttons.DoneButton).gameObject.BindEvent(OnClickedDoneBtn);
        GetButton((int)Buttons.DoneButton).gameObject.SetActive(false);

        int i = 0;
        foreach (Transform child in GetObject((int)GameObjects.CharacterPanel).transform)
        {
            int tmp = i;
            child.gameObject.BindEvent(() => {
                OnClickedCharacterBtn(tmp);
                Debug.Log(child.gameObject.name);
            });
            i += 1;
        }

        /*i = 0;
        foreach (Transform child in GetObject((int)GameObjects.PositionPanel).transform)
        {
            int tmp = i;
            child.gameObject.BindEvent(() => {
                OnClickedPositionBtn(tmp);
                Debug.Log(child.gameObject.name);
            });
            child.gameObject.SetActive(false);
            i += 1;
        }*/

        i = 0;
        foreach (Transform child in GetObject((int)GameObjects.WeaponPanel).transform)
        {
            int tmp = i;
            child.gameObject.BindEvent(() => {
                OnClickedWeaponBtn(tmp);
                Debug.Log(child.gameObject.name);
            });
            child.gameObject.SetActive(false);
            i += 1;
        }

        GetComponent<Canvas>().sortingOrder = 10;

        return true;
    }

    void OnClickedCharacterBtn(int idx)
    {
        Debug.Log("idx: " + idx);
        if(Managers.Ally.isSet[idx]) Managers.Ally.isSet[idx] = !Managers.Ally.isSet[idx];
        characterNum = idx;
        GetText((int)Texts.TitleTMP).text = "함께 싸울 아군"+ IntToEnum<Characters>(characterNum).ToString() +"의 무기를 지정하세요.";
        int i = 0;
        foreach (Transform child in GetObject((int)GameObjects.WeaponPanel).transform)
        {
            int tmp = i;
            child.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = weapons[characterNum][tmp];
            child.gameObject.SetActive(true);
            i++;
        }
    }

    /*void OnClickedPositionBtn(int idx)
    {
        Debug.Log("idx: " + idx);
        GetText((int)Texts.TitleTMP).text = "함께 싸울 아군"+ IntToEnum<Characters>(characterNum).ToString() +"의 무기를 지정하세요.";
        Managers.Ally.allies[characterNum].position = idx;
        position = idx;
        int i = 0;
        foreach (Transform child in GetObject((int)GameObjects.WeaponPanel).transform)
        {
            int tmp = i;
            child.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = weapons[characterNum][tmp];
            child.gameObject.SetActive(true);
            i++;
        }
    }*/

    void OnClickedWeaponBtn(int idx)
    {
        Debug.Log("idx: " + idx);
        Managers.Ally.allies[characterNum].position = idx;
        position = idx;
        Managers.Ally.allies[characterNum].weapon = weapons[characterNum][position];
        Managers.Ally.isSet[characterNum] = true;
        GetButton((int)Buttons.DoneButton).gameObject.SetActive(true);
        SetDicisionPanel(characterNum);

        /*foreach (Transform child in GetObject((int)GameObjects.PositionPanel).transform)
        {
            child.gameObject.SetActive(false);
        }*/
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
            GetText((int)Texts.TitleTMP).text = "함께 싸울 아군 정보를 확인 후 시작하세요\n 혹은 바꾸고 싶은 아군을 선택하세요.";
            return;
        }
        GetText((int)Texts.TitleTMP).text = "함께 싸울 아군을 지정하세요.";
    }

    void OnClickedDoneBtn()
    {
        if(isDone)
        {
           Managers.Scene.ChangeScene(Define.Scene.BattleScene);
        }
    }

    void SetDicisionPanel(int idx)
    {
        int i = 0;
        string info = "캐릭터: " + IntToEnum<Characters>(characterNum).ToString() + "\n위치: "  + IntToEnum<Position>(position).ToString() + "\n무기: " + weapons[characterNum][position];
        foreach (Transform child in GetObject((int)GameObjects.DicisionPanel).transform)
        {
            int tmp = i;
            if(tmp == idx) 
            {
                child.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = info;
                break;
            }
            i++;
        }
    }

    public T IntToEnum<T>(int e)
    {
        return (T)(object)e;
    }
}
