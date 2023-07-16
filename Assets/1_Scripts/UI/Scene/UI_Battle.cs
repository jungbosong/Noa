using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Battle : UI_Scene
{
    enum GameObjects
    {
        HPSlider,
        AlliesPanel,
        EnemiesPanel,
        SkillPanel,
    }
    enum Texts
    {
        DFText,
        ADText,
        SPDText,
        CRTText,
        HEATText,
    }

    enum Buttons
    {
        Skill1Button,
        Skill2Button,
        Skill3Button,
        Skill4Button,
        SetAlliesButton,
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObject(typeof(GameObjects));
        BindText(typeof(Texts));
        BindButton(typeof(Buttons));

        CreateAllies();
        CreateEnemies();
        GetButton((int)Buttons.SetAlliesButton).gameObject.BindEvent(OnClickedSetAlliesBtn);

        return true;
    }

    public void CreateAllies()
    {
        Transform alliesPanel = GetObject((int)GameObjects.AlliesPanel).transform;
        foreach (Transform child in alliesPanel)
            Managers.Resource.Destroy(child.gameObject);

        for (int i = 0; i < 4; i++)
        {
            GameObject item = Managers.UI.MakeSubItem<UI_Allies>(alliesPanel, "AlliesButton").gameObject;
            UI_Allies ally = item.GetOrAddComponent<UI_Allies>();
            if (ally.Init())
                ally.SetInfo();
        }
    }

    public void CreateEnemies()
    {
        Transform enemiesPanel = GetObject((int)GameObjects.EnemiesPanel).transform;
        foreach (Transform child in enemiesPanel)
            Managers.Resource.Destroy(child.gameObject);

        for (int i = 0; i < 4; i++)
        {
            GameObject item = Managers.UI.MakeSubItem<UI_Enemies>(enemiesPanel, "EnemiesButton").gameObject;
            UI_Enemies enemy = item.GetOrAddComponent<UI_Enemies>();
            if (enemy.Init())
                enemy.SetInfo();
        }
    }

    void OnClickedSetAlliesBtn()
    {
        Managers.UI.ShowPopupUI<UI_SetAllies>();
    }
}