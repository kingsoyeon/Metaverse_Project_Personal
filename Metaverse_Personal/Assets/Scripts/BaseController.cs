using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    // ��������Ʈ ������ 
    [SerializeField] private SpriteRenderer characterRendere;

    // �̵� ����
    protected Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }

    // �ٶ󺸴� ����
    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }


    protected virtual void Awake() 
    {

    }
    protected virtual void Start() 
    { }

    protected virtual void Update() 
    { }
    
}
