using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    // 파라미터를 해시값으로 변경
    private static readonly int IsMoving = Animator.StringToHash("IsMove");

    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    protected virtual void Move(Vector2 obj)
    {
        // 벡터의 길이가 0.5보다 크면 움직이는 애니메이션 출력
        animator.SetBool(IsMoving, obj.magnitude>.5f);
    }
}
