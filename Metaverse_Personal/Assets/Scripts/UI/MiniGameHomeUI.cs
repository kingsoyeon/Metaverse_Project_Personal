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
    // �̴ϰ��� ���۹�ư - �̴ϰ��� ȭ������ �̵�
    void OnClickStartButton()
    {
        uiManager.MiniGameStart();
    }

    // �̴ϰ��� �����ư
    void OnClickExplainButton() 
    {
        uiManager.MiniGameExplain();
    }
    // �̴ϰ��� �����ư - �̴ϰ��� ������ ����
    void OnClickExitButton()
    {
        Debug.Log("Exit button clicked!");
        uiManager.MiniGameExit();
    }
}
