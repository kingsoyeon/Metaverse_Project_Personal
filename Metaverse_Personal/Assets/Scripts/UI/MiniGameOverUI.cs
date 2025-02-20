using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameOverUI : BaseUI
{
    [SerializeField] private Button restartBtn;
    [SerializeField] private Button exitBtn;

    protected override UIState GetUIState()
    {
        return UIState.MiniGameOver;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);

        restartBtn = transform.Find("RestartBtn").GetComponent<Button>();
        exitBtn = transform.Find("ExitBtn").GetComponent<Button>();

        restartBtn.onClick.AddListener(OnClickReStartButton);
        exitBtn.onClick.AddListener(OnClickExitButton);
    }


    

    // 미니게임 나가기 버튼

    public void OnClickExitButton() 
    {
        uiManager.MiniGameExit();
    }

    // 미니게임 재시작 버튼
    public void OnClickReStartButton() 
    {
        uiManager.MiniGameStart();
    }
}
    

