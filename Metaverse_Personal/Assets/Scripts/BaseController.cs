using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    
    protected Rigidbody2D _rigidbody;

    // ��������Ʈ ������ 
    [SerializeField] private SpriteRenderer characterRenderer;

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
    {
        Rotate(lookDirection);
    }

    protected virtual void FixedUpdate()
    {
        Movement(MoveDirection);
    }

    protected virtual void HandleInput() { }
    private void Movement(Vector2 direction) 
    {
        // ���⺤�� * ���� = ũ��(�ӵ�)
        direction = direction * 5;
        
        // rigidbody�� �ӵ�
        // direction�� ���� �ӵ��� ������
        // ���� (1,0)�̸� �ӵ��� 1
        _rigidbody.velocity = direction;
    }

    private void Rotate(Vector2 direction) 
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // 90f�� �Ѵ´ٸ� ������ �ٶ�
        bool isLeft = Mathf.Abs(rotZ) > 90f;

        characterRenderer.flipX = isLeft;
    }
    
}
