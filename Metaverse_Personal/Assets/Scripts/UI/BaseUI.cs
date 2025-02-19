using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUI : MonoBehaviour
{
    protected UIManager uiManager;

    // uimanager ����
    public virtual void Init(UIManager uiManager)
    {
        this.uiManager = uiManager;
    }

    // �ڽ� Ŭ�������� UI state ������
    protected abstract UIState GetUIState();

    // ���� UI�� state�� ������ gameObject.SetActive(true); ���� (UI�� �Ҵ�.)
    public void SetActive(UIState state)
    {
        gameObject.SetActive(GetUIState() == state);
    }

}
