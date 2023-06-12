using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Store : UI_Scene
{
    enum Texts
    {
        TitleTMP,
    }

    enum Buttons
    {
        PurchaseRelicBtn,
        EnhanceSkillBtn,
        RecoverBtn,
        BackBtn,
    }

    enum GameObjects
    {

    }

    private void Start()
    {
        Init();
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindText(typeof(Texts));
        BindButton(typeof(Buttons));
        BindObject(typeof(GameObjects));

        GetText((int)Texts.TitleTMP).text = "상점";
        GetButton((int)Buttons.BackBtn).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.LobbyScene);});

        return true;
    }
}
