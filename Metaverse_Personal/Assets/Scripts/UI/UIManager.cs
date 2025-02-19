using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
            if (instance == null) { instance = FindObjectOfType<UIManager>(); }
            return instance;
        }
    }

    private void Awake()
    {
       
        // 싱글톤 씬이 넘어가도 없어지지않도록
        if(Instance == null) { instance = this; DontDestroyOnLoad(gameObject); }
        else { Destroy(gameObject); return; }

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

    // 미니게임을 실행했을 때 뜨는 UI
    public void MiniGameHome() 
    {
        ChangeState(UIState.MinigameHome);
    }

    // 메인 관련 UI


    // 미니게임 관련 UI
    // 미니게임 시작을 누르면 뜨는 UI (게임 중 ui)
    public void MiniGameStart() 
    {
        ChangeState(UIState.MiniGame);
    }

    // 미니게임 설명화면 UI
    public void MiniGameExplain()
    {
        ChangeState(UIState.MiniGameExplain);
    }

    // 미니게임 오버됐을 때 UI (스코어, 최고점수, 다시하기, 종료)
    public void MiniGameOver() 
    {
        ChangeState(UIState.MiniGameOver);
    }

    // 미니게임 종료 - 하우스씬으로 다시 돌아감
    public void MiniGameExit() 
    {
        SceneManager.LoadScene("HouseScene");
    }

    // 미니게임 재시작 - 미니게임시작됨
    public void MiniGameReStart()
    {
        ChangeState(UIState.MiniGame);
    }
    
}
