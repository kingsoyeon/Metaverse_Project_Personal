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
    public void GameOver()
    {
        if (isGameOver) return;
        
           
            uiManager.MiniGameOver();
        
        Time.timeScale = 0;
       

    }

    // ���� �����
    public void GameRestart()
    {
        uiManager.MiniGameStart();
        Time.timeScale = 1;

    }

    // ���� �߰�
    public void AddScore(int score)
    {
        currentScore += score;

            uiManager.UpdateScore(currentScore);
        
    }
}
