using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreScene : BaseScene
{
    protected override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.Scene.StoreScene;
        Managers.UI.ShowSceneUI<UI_Store>();
        return true;
    }
}
