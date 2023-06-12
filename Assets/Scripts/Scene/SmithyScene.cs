using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmithyScene : BaseScene
{
    protected override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.Scene.SmithyScene;
        Managers.UI.ShowSceneUI<UI_Smithy>();
        return true;
    }
}