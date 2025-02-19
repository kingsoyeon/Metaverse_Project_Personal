using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum UIState
{
    // ���� UI


    // �̴ϰ��� UI
    MinigameHome,
    MiniGame,
    MiniGameExplain,
    MiniGameOver
}
public class UIManager : MonoBehaviour
{
    MiniGameHomeUI miniHomeUI;
    MiniGameUI miniGameUI;
    MiniGameExplainUI miniExplainUI;
    MiniGameOverUI miniGameOverUI;

    private UIState currentState;



    // �̱���
    static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;

        miniHomeUI = GetComponentInChildren<MiniGameHomeUI>(true);
        miniHomeUI.Init(this);

        miniGameUI = GetComponentInChildren<MiniGameUI>(true);
        miniGameUI.Init(this);

        miniExplainUI = GetComponentInChildren<MiniGameExplainUI>(true);
        miniExplainUI.Init(this);

        miniGameOverUI = GetComponentInChildren<MiniGameOverUI>(true);
        miniGameOverUI.Init(this);

    }

    // UI ����
    public void ChangeState(UIState state)
    {
        currentState = state;
        miniHomeUI.SetActive(currentState);
        miniGameUI.SetActive(currentState);
        miniExplainUI.SetActive(currentState);
        miniGameOverUI.SetActive(currentState);
    }

    // �̴ϰ��� ���� UI
    public void MiniGameHome() 
    {
        ChangeState(UIState.MinigameHome);
    }

    // �̴ϰ��� ���� UI
    public void MiniGameStart() 
    {
        ChangeState(UIState.MiniGame);
    }

    // �̴ϰ��� ���� UI
    public void MiniGameExplain()
    {
        ChangeState(UIState.MiniGameExplain);
    }

    // �̴ϰ��� ���� UI
    public void MiniGameOver() 
    {
        ChangeState(UIState.MiniGameOver);
    }

    

}
