using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionScene : BaseScene
{
    protected override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.Scene.MissionScene;
        Managers.UI.ShowSceneUI<UI_Mission>();
        return true;
    }
}
