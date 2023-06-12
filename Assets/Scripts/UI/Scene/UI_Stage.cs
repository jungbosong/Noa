using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Stage : UI_Scene
{
    enum Texts
    {
        TitleTMP,
    }

    enum Buttons
    {
        StationBtn,
        Stage1Btn,
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

        GetText((int)Texts.TitleTMP).text = "스테이지";
        GetButton((int)Buttons.StationBtn).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.LobbyScene);});

        return true;
    }
}
