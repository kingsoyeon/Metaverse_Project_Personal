using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum UIState
{
    // ∏ﬁ¿Œ UI


    // πÃ¥œ∞‘¿” UI
    MinigameHome,
    MiniGame,
    MiniGameExplain,
    MiniGameOver
}
public class UIManager : MonoBehaviour
{
    MiniGameHomeUI miniHomeUI;
    MiniGameUI miniGameUI;
    MiniGameExplainUI miniExplainUI;
    MiniGameOverUI miniGameOverUI;

    private UIState currentState;



    // ΩÃ±€≈Ê
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

        miniHomeUI = GetComponentInChildren<MiniGameHomeUI>(true);
        miniHomeUI.Init(this);

        miniGameUI = GetComponentInChildren<MiniGameUI>(true);
        miniGameUI.Init(this);

        miniExplainUI = GetComponentInChildren<MiniGameExplainUI>(true);
        miniExplainUI.Init(this);

        miniGameOverUI = GetComponentInChildren<MiniGameOverUI>(true);
        miniGameOverUI.Init(this);
\ 
    }

    public void ChangeState(UIState state)
    {
        
    }

}
