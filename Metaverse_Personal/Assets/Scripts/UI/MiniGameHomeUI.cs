using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameHomeUI : BaseUI
{
    protected override UIState GetUIState()
    {
        throw new System.NotImplementedException();
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
    }

    // 미니게임 시작 버튼
    public void MiniStartButton() { }

    // 미니게임 나가기 버튼
    public void MiniEndButton() { }
}
