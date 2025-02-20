using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public UIManager uiManager;

    private bool isGameOver = false;

    // �̱���
    private void Awake()
    {

        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        isGameOver = false;
        Time.timeScale = 0;
    }

    private int currentScore = 0;

    

    // ���� ����
    

    // ���� �����
    public void GameRestart()
    {
        isGameOver = false;
        currentScore = 0;
        uiManager.UpdateScore(currentScore);
        uiManager.MiniGameStart();
        Time.timeScale = 1;

    }

    // ���� �߰�
    public void AddScore(int score)
    {
        currentScore += score;

            uiManager.UpdateScore(currentScore);

        //PlayerPrefs.SetInt("Last Score", currentScore);
        //PlayerPrefs.Save();

        int bestScore = PlayerPrefs.GetInt("Best Score", 0);

        if (currentScore > bestScore) // ���� ������ �ְ� �������� ������ ����
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
