using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
            if (instance == null) { instance = FindObjectOfType<UIManager>(); }
            return instance;
        }
    }

    private void Awake()
    {
       
        // �̱��� ���� �Ѿ�� ���������ʵ���
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

    // UI ����
    public void ChangeState(UIState state)
    {
        currentState = state;
        miniHomeUI.SetActive(currentState);
        miniGameUI.SetActive(currentState);
        miniExplainUI.SetActive(currentState);
        miniGameOverUI.SetActive(currentState);
    }

    // �̴ϰ����� �������� �� �ߴ� UI
    public void MiniGameHome() 
    {
        ChangeState(UIState.MinigameHome);
    }

    // ���� ���� UI


    // �̴ϰ��� ���� UI
    // �̴ϰ��� ������ ������ �ߴ� UI (���� �� ui)
    public void MiniGameStart() 
    {
        ChangeState(UIState.MiniGame);
    }

    // �̴ϰ��� ����ȭ�� UI
    public void MiniGameExplain()
    {
        ChangeState(UIState.MiniGameExplain);
    }

    // �̴ϰ��� �������� �� UI (���ھ�, �ְ�����, �ٽ��ϱ�, ����)
    public void MiniGameOver() 
    {
        ChangeState(UIState.MiniGameOver);
    }

    // �̴ϰ��� ���� - �Ͽ콺������ �ٽ� ���ư�
    public void MiniGameExit() 
    {
        SceneManager.LoadScene("HouseScene");
    }

    // �̴ϰ��� ����� - �̴ϰ��ӽ��۵�
    public void MiniGameReStart()
    {
        ChangeState(UIState.MiniGame);
    }
    
}
