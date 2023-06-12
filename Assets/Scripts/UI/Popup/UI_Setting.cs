using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Setting :  UI_Popup
{
    enum Buttons
    {
        BackBtn,
    }
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindButton(typeof(Buttons));

        GetButton((int)Buttons.BackBtn).gameObject.BindEvent(() => { Managers.Scene.ChangeScene(Define.Scene.MainScene);});

        GetComponent<Canvas>().sortingOrder = 10;

        return true;
    }
}
