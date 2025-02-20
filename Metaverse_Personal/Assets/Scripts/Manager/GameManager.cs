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
    }

    private int currentScore = 0;

    

    // ���� ����
    public void GameOver()
    {
        if (isGameOver) return;
        
           
            uiManager.MiniGameOver();
       

    }

    // ���� �����
    public void GameRestart()
    {
        uiManager.MiniGameStart();

    }

    // ���� �߰�
    public void AddScore(int score)
    {
        currentScore += score;

            uiManager.UpdateScore(currentScore);
        
    }
}
