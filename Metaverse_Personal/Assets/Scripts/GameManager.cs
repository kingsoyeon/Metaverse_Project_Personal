using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance;
    public UIManager uiManager;
    
    // �̱���
    private void Awake()
    {

        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private int cureentScore = 0;

    // ���� ����
    public void GameOver()
    {

        
    }

    // ���� �����
    public void GameRestart()
    {
        

    }

    // ���� �߰�
    public void AddScore(int score)
    {
        cureentScore += score;
    }
}
