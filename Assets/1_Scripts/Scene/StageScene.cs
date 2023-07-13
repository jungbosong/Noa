using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScene : BaseScene
{
    protected override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.Scene.StageScene;
        Managers.UI.ShowSceneUI<UI_Stage>();
        return true;
    }
}
