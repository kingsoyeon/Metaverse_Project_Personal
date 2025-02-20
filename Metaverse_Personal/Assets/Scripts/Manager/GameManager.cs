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
        Time.timeScale = 0;
    }

    private int currentScore = 0;

    

    // 게임 오버
    

    // 게임 재시작
    public void GameRestart()
    {
        isGameOver = false;
        currentScore = 0;
        uiManager.UpdateScore(currentScore);
        uiManager.MiniGameStart();
        Time.timeScale = 1;

    }

    // 점수 추가
    public void AddScore(int score)
    {
        currentScore += score;

            uiManager.UpdateScore(currentScore);

        //PlayerPrefs.SetInt("Last Score", currentScore);
        //PlayerPrefs.Save();

        int bestScore = PlayerPrefs.GetInt("Best Score", 0);

        if (currentScore > bestScore) // 현재 점수가 최고 점수보다 높으면 갱신
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("Best Score", bestScore);
            PlayerPrefs.Save();
            
        }
        
        uiManager.UpdateBestScore();
    }
    public void GameOver()
    {
        if (isGameOver) return;
        Time.timeScale = 0;

       // PlayerPrefs.SetInt("Last Score", currentScore);
      //  PlayerPrefs.Save();

        uiManager.UpdateScore(currentScore);
        uiManager.MiniGameOver();
        
    }
}
