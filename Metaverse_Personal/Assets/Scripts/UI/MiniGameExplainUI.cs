using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameExplainUI : BaseUI
{
    [SerializeField] private Button startBtn;

    protected override UIState GetUIState()
    {
        return UIState.MiniGameExplain;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);

        startBtn = transform.Find("StartBtn").GetComponent<Button>();
        startBtn.onClick.AddListener(OnClickStartButton);
    }


    // �̴ϰ��� ���� ��ư
    void OnClickStartButton()
    {
        uiManager.MiniGameStart();
    }

   
}
