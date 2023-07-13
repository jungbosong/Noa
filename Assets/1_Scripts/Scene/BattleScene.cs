using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScene : BaseScene
{
    protected override bool Init()
    {
        if (base.Init() == false)
            return false;

        SceneType = Define.Scene.BattleScene;
        Managers.UI.ShowSceneUI<UI_Battle>();
        return true;
    }
}
