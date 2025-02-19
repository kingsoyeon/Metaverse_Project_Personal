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

    // Ä§´ë ¸»Ç³¼± UI
    public GameObject sleepUI;

    public Button YesButton;
    public Button NoButton;

    private void Start()
    {
        

        sleepUI.SetActive(false);
        YesButton.onClick.AddListener(OnYesButton);
        NoButton.onClick.AddListener(OnNoButton);
    }
    
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player")) { sleepUI.SetActive(true); }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) { sleepUI.SetActive(false); }
    }

    public void OnYesButton() { SceneManager.LoadScene("MiniGameScene"); }
    public void OnNoButton() { sleepUI.SetActive(false); }

   
}
   

