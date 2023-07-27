using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAlliesScene : BaseScene
{
    protected override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.Scene.SetAlliesScene;
        Managers.UI.ShowSceneUI<UI_SetAllies>();
        return true;
    }
}