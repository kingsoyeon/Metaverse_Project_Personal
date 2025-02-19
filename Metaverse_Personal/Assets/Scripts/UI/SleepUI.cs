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

    // ħ�� ��ǳ�� UI
    public GameObject sleepUI;

    // YES,NO ��ư
    public Button YesButton;
    public Button NoButton;

    // SleepUI���� NO�� ��������
    private bool isNo = false; // ó���� �� ���� ����

    private void Start()
    {
       
        sleepUI.SetActive(false);
        YesButton.onClick.AddListener(OnYesButton);
        NoButton.onClick.AddListener(OnNoButton);
    }
    
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player")) 
            // No�� ������ ���� ���¿����� UiȰ��ȭ
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
            // �ʱ�ȭ
            isNo = false;
        }
    }

    // yes ��ư -> �̴ϰ��Ӿ����� ��ȯ
    public void OnYesButton() { SceneManager.LoadScene("MiniGameScene"); }

    // NO ��ư -> UI ��Ȱ��ȭ (no ��ư�� ������ ������)
    public void OnNoButton() 
    {  
        sleepUI.SetActive(false);
        // no ��ư�� �������Ƿ�
        isNo = true;
        
    }

   
}
   

