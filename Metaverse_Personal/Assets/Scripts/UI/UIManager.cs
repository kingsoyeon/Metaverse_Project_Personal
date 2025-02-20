using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public enum UIState
{
    // 메인 UI


    // 미니게임 UI

   

    MiniGameHome, // 미니게임 홈
    MiniGame, // 미니게임 화면
    MiniGameExplain, // 미니게임 설명화면
    MiniGameOver // 미니게임 오버
}
public class UIManager : MonoBehaviour
{
    // 침대에 가까이 가면 뜨는 UI

    [SerializeField] private GameObject homeUI;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject explainUI;
    [SerializeField] private GameObject gameOverUI;

    // 파이프, 플레이어
    //[SerializeField] private GameObject Obstacles;
    //[SerializeField] private GameObject player;




    public MiniGameHomeUI miniHomeUI;
    public MiniGameUI miniGameUI;
    public MiniGameExplainUI miniExplainUI;
    public MiniGameOverUI miniGameOverUI;



    private UIState currentState;

    // 점수, 최고점수
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI BestScoreText;


    // 싱글톤
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
        // 싱글톤 씬이 넘어가도 없어지지않도록
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


    // UI 변경
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

    // 미니게임을 실행했을 때 뜨는 UI
    public void MiniGameHome() 
    {
        ChangeState(UIState.MiniGameHome);
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

    // ui에 점수 업데이트 반영
    public void UpdateScore(int score)
    {
        ScoreText.text = score.ToString();
    }
}
