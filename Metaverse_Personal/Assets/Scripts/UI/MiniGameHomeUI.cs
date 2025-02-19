using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniGameHomeUI : BaseUI
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button explainButton;
    [SerializeField] private Button exitButton;

    

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
        
        startButton = transform.Find("StartButton").GetComponent<Button>();
        explainButton = transform.Find("HowToPlay").GetComponent<Button>();
        exitButton = transform.Find("ExitButton").GetComponent<Button>();

        

        startButton.onClick.AddListener(OnClickStartButton);
        explainButton.onClick.AddListener(OnClickExplainButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    protected override UIState GetUIState()
    {
        return UIState.MinigameHome;
    }
    // 미니게임 시작버튼 - 미니게임 화면으로 이동
    void OnClickStartButton()
    {
        uiManager.MiniGameStart();
    }

    // 미니게임 설명버튼
    void OnClickExplainButton() 
    {
        uiManager.MiniGameExplain();
    }
    // 미니게임 종료버튼 - 미니게임 씬에서 나감
    void OnClickExitButton()
    {
        Debug.Log("Exit button clicked!");
        uiManager.MiniGameExit();
    }
}
