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
    // MainUI¿Í MiniGameUIÀÇ ¸®½ºÆ®
    private List<MainUI> MainUIList = new List<MainUI>();
    private List<MiniGameUI> MiniGameUIList = new List<MiniGameUI>();

    // ½Ì±ÛÅæ
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
