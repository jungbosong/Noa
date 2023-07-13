using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Define
{
     public enum UIEvent
    {
        Click,
        Pressed,
        PointerDown,
        PointerUp,
    }

    public enum Scene
    {
        Unknown,
        Dev,
        MainScene,
        LobbyScene,
        SmithyScene,
        MissionScene,
        StoreScene,
        StageScene,
        EnhanceScene,
        BattleScene,
    }

    public enum Sound
    {
        Bgm,
        Effect,
        Speech,
        Max,
    }

    public enum Mode
    {
        Unknown,
    }
}
