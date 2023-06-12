using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Mission : UI_Scene
{
    enum Texts
    {
        TitleTMP,
    }

    enum Buttons
    {
        MainMissionBtn,
        RewardMisionBtn,
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

        GetText((int)Texts.TitleTMP).text = "임무";
        GetButton((int)Buttons.BackBtn).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.LobbyScene);});

        return true;
    }
}
