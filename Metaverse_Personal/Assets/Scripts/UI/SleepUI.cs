using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SleepUI : BaseUI
{
    protected override UIState GetUIState()
    {
        return UIState.MinigameHome;
    }

    // 침대 말풍선 UI
    public GameObject sleepUI;

    // YES,NO 버튼
    public Button YesButton;
    public Button NoButton;

    // SleepUI에서 NO를 눌렀는지
    private bool isNo = false; // 처음은 안 누른 상태

    private void Start()
    {
       
        sleepUI.SetActive(false);
        YesButton.onClick.AddListener(OnYesButton);
        NoButton.onClick.AddListener(OnNoButton);
    }
    
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player")) 
            // No를 누르지 않은 상태에서만 Ui활성화
            {if (!isNo)
            {
                sleepUI.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        { 
            sleepUI.SetActive(false);
            // 초기화
            isNo = false;
        }
    }

    // yes 버튼 -> 미니게임씬으로 전환
    public void OnYesButton() { SceneManager.LoadScene("MiniGameScene"); }

    // NO 버튼 -> UI 비활성화 (no 버튼을 누르기 전까지)
    public void OnNoButton() 
    {  
        sleepUI.SetActive(false);
        // no 버튼을 눌렀으므로
        isNo = true;
        
    }

   
}
   

