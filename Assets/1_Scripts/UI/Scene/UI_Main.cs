using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Define;

public class UI_Main : UI_Scene
{
    enum Buttons
    {
        StartButton,
        SettingButton,
        QuitButton,
    }
    
    enum Images
    {
        LogoImage,
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

        BindButton(typeof(Buttons));
        BindImage(typeof(Images));
        BindObject(typeof(GameObjects));

        GetImage((int)Images.LogoImage).sprite = Resources.Load<Sprite>("Sprites/Noah") as Sprite;
        GetButton((int)Buttons.StartButton).gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Start") as Sprite;
        GetButton((int)Buttons.SettingButton).gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Setting") as Sprite;
        GetButton((int)Buttons.QuitButton).gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Exit") as Sprite;

        GetButton((int)Buttons.StartButton).gameObject.BindEvent(() => { 
            //Managers.UI.ShowPopupUI<UI_SetAllies>();
            Managers.Scene.ChangeScene(Define.Scene.SetAlliesScene);});
        GetButton((int)Buttons.SettingButton).gameObject.BindEvent(() => { Managers.UI.ShowPopupUI<UI_Setting>();});
        GetButton((int)Buttons.QuitButton).gameObject.BindEvent(() => { Managers.UI.ShowPopupUI<UI_QuitGame>();});

        return true;
    }
}
