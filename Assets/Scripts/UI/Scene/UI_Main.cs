using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Define;

public class UI_Main : UI_Scene
{
    enum Texts
    {
        TitleTMP,
    }

    enum Buttons
    {
        StartButton,
        SettingButton,
        QuitButton,
    }
    
    enum Images
    {
        BGImage,
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
        BindImage(typeof(Images));
        BindObject(typeof(GameObjects));

        GetText((int)Texts.TitleTMP).text = "노아";
        GetButton((int)Buttons.StartButton).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.LobbyScene);});
        GetButton((int)Buttons.SettingButton).gameObject.BindEvent(() => { Managers.UI.ShowPopupUI<UI_Setting>();});
        GetButton((int)Buttons.QuitButton).gameObject.BindEvent(() => { Managers.UI.ShowPopupUI<UI_QuitGame>();});

        return true;
    }
}
