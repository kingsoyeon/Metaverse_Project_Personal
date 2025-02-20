using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public UIManager uiManager;

    private bool isGameOver = false;

    // 싱글톤
    private void Awake()
    {

        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        isGameOver = false;
    }

    private int currentScore = 0;

    

    // 게임 오버
    public void GameOver()
    {
        if (isGameOver) return;
        
           
            uiManager.MiniGameOver();
       

    }

    // 게임 재시작
    public void GameRestart()
    {
        uiManager.MiniGameStart();

    }

    // 점수 추가
    public void AddScore(int score)
    {
        currentScore += score;

            uiManager.UpdateScore(currentScore);
        
    }
}
