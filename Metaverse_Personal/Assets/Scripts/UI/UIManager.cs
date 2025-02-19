using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum UIState
{
    // 메인 UI


    // 미니게임 UI
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



    // 싱글톤
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

    // UI 변경
    public void ChangeState(UIState state)
    {
        currentState = state;
        miniHomeUI.SetActive(currentState);
        miniGameUI.SetActive(currentState);
        miniExplainUI.SetActive(currentState);
        miniGameOverUI.SetActive(currentState);

    }

    // 미니게임 시작
    public void MiniGameStart() { }

    // 미니게임 오버
    public void MiniGameOver() { }

    // 시작 버튼
    
    // 나가기 버튼
    
    // 재시작 버튼

}
