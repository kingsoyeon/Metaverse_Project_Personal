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
        // �ڽ�Ŭ�������� ��� rigidbody�� ����
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    protected virtual void Start() 
    { }

    protected virtual void Update() 
    { }

    protected virtual void FixedUpdate()
    {
        Movement(MoveDirection);
    }
    private void Movement(Vector2 direction) 
    {
        // ���⺤�� * ���� = ũ��(�ӵ�)
        direction = direction * 5;
        
        // rigidbody�� �ӵ�
        // direction�� ���� �ӵ��� ������
        // ���� (1,0)�̸� �ӵ��� 1
        _rigidbody.velocity = direction;
    }

    private void Rotate() 
    {
    }
    
}
