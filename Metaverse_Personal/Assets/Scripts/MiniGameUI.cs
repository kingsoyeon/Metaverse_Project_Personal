using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameUI : BaseUI
{
    [SerializeField] private UIState uiState;

    
    protected override UIState GetUIState()
    {
        return uiState;
    }

}
