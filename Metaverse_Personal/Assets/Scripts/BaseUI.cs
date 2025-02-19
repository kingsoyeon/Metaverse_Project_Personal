using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUI : MonoBehaviour
{
    protected UIManager uiManager;

    // uimanager 참조
    public virtual void Init(UIManager uiManager)
    {
        this.uiManager = uiManager;
    }

    // 자식 클래스에서 UI state 가져옴
    protected abstract UIState GetUIState();

    // 현재 UI가 state와 같으면 gameObject.SetActive(true); 실행 (UI를 켠다.)
    public void SetActive(UIState state)
    {
        gameObject.SetActive(GetUIState() == state);
    }

}
