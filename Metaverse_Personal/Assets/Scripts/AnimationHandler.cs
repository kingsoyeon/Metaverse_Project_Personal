using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    // �Ķ���͸� �ؽð����� ����
    private static readonly int IsMoving = Animator.StringToHash("IsMove");

    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    protected virtual void Move(Vector2 obj)
    {
        // ������ ���̰� 0.5���� ũ�� �����̴� �ִϸ��̼� ���
        animator.SetBool(IsMoving, obj.magnitude>.5f);
    }
}
