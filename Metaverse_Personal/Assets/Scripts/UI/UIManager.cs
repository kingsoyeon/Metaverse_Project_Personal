using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public enum UIState
{
    // ���� UI


    // �̴ϰ��� UI

   

    MiniGameHome, // �̴ϰ��� Ȩ
    MiniGame, // �̴ϰ��� ȭ��
    MiniGameExplain, // �̴ϰ��� ����ȭ��
    MiniGameOver // �̴ϰ��� ����
}
public class UIManager : MonoBehaviour
{
    // ħ�뿡 ������ ���� �ߴ� UI

    [SerializeField] private GameObject homeUI;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject explainUI;
    [SerializeField] private GameObject gameOverUI;

    // ������, �÷��̾�
    //[SerializeField] private GameObject Obstacles;
    //[SerializeField] private GameObject player;




    public MiniGameHomeUI miniHomeUI;
    public MiniGameUI miniGameUI;
    public MiniGameExplainUI miniExplainUI;
    public MiniGameOverUI miniGameOverUI;



    private UIState currentState;

    // ����, �ְ�����
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI BestScoreText;


    // �̱���
    //static UIManager instance;
    //public static UIManager Instance
    // {
    // get
    // {
    //  if (instance == null) { instance = FindObjectOfType<UIManager>(); }
    //  return instance;
    //  }
    // }

    // MiniGameHomeUI homeUI = null;

    // MiniGameUI gameUI = null;
    //  MiniGameOverUI overUI = null;
    //  MiniGameExplainUI explainUI = null;



    private void Awake()
    {
        //Debug.Log("UIManager Awake");
        // �̱��� ���� �Ѿ�� ���������ʵ���
       // if (Instance == null) { instance = this; DontDestroyOnLoad(gameObject); }
        //else { Destroy(gameObject); return; }

       // miniHomeUI = GetComponentInChildren<MiniGameHomeUI>(true);
       // miniHomeUI.Init(this);

       // miniGameUI = GetComponentInChildren<MiniGameUI>(true);
      //  miniGameUI.Init(this);

       // miniExplainUI = GetComponentInChildren<MiniGameExplainUI>(true);
       // miniExplainUI.Init(this);

       // miniGameOverUI = GetComponentInChildren<MiniGameOverUI>(true);
       // miniGameOverUI.Init(this);

        ChangeState(UIState.MiniGameHome);

    }
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "MiniGameScene")
        {
            miniHomeUI = homeUI.GetComponent<MiniGameHomeUI>();
            miniGameUI = gameUI.GetComponent<MiniGameUI>();
            miniExplainUI = explainUI.GetComponent<MiniGameExplainUI>();
            miniGameOverUI = gameOverUI.GetComponent<MiniGameOverUI>();

            miniHomeUI.Init(this);
            miniGameUI.Init(this);
            miniExplainUI.Init(this);
            miniGameOverUI.Init(this);

            ChangeState(UIState.MiniGameHome);
        }
    }


    // UI ����
    public void ChangeState(UIState state)
    {
        currentState = state;

        // miniHomeUI.gameObject.SetActive(state == UIState.MinigameHome);
        //miniGameUI.gameObject.SetActive(state == UIState.MiniGame);
        // miniExplainUI.gameObject.SetActive(state == UIState.MiniGameExplain);
        // miniGameOverUI.gameObject.SetActive(state == UIState.MiniGameOver);

        homeUI.SetActive(state == UIState.MiniGameHome);
        gameUI.SetActive(state == UIState.MiniGame);
        explainUI.SetActive(state == UIState.MiniGameExplain);
        gameOverUI.SetActive(state == UIState.MiniGameOver);


        //Obstacles.SetActive(state == UIState.MiniGame);
        //player.SetActive(state == UIState.MiniGame);
    }

    // �̴ϰ����� �������� �� �ߴ� UI
    public void MiniGameHome() 
    {
        ChangeState(UIState.MiniGameHome);
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

    // ui�� ���� ������Ʈ �ݿ�
    public void UpdateScore(int score)
    {
        ScoreText.text = score.ToString();
    }
}
