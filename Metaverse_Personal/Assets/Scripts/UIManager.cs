using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum UIState
{
    Home,
    Game,
    Explain,
    GameOver
}
public class UIManager : MonoBehaviour
{
    // MainUI�� MiniGameUI�� ����Ʈ
    private List<MainUI> MainUIList = new List<MainUI>();
    private List<MiniGameUI> MiniGameUIList = new List<MiniGameUI>();

    // �̱���
    static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;

    }





}
