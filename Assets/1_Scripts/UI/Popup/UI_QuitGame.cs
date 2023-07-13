using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_QuitGame : UI_Popup
{
    public enum Buttons
    {
        QuitBtn,
        ToMainBtn,
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindButton(typeof(Buttons));

        GetButton((int)Buttons.QuitBtn).gameObject.BindEvent(() => { Application.Quit();});
        GetButton((int)Buttons.ToMainBtn).gameObject.BindEvent(() => { ClosePopupUI();});

        GetComponent<Canvas>().sortingOrder = 10;

        return true;
    }
}