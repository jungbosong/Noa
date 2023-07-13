using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Lobby : UI_Scene
{
    enum Texts
    {
        TitleTMP,
    }

    enum Buttons
    {
        BlacksmithBtn,
        MissionBtn,
        StoreBtn,
        StageBtn,
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

        GetText((int)Texts.TitleTMP).text = "로비";
        GetButton((int)Buttons.BlacksmithBtn).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.SmithyScene);});
        GetButton((int)Buttons.MissionBtn).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.MissionScene);});
        GetButton((int)Buttons.StoreBtn).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.StoreScene);});
        GetButton((int)Buttons.StageBtn).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.StageScene);});

        return true;
    }
}
