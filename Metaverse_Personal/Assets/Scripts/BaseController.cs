using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    
    protected Rigidbody2D _rigidbody;

    // 스프라이트 렌더러 
    [SerializeField] private SpriteRenderer characterRendere;

    // 이동 방향
    protected Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }

    // 바라보는 방향
    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 LookDirection { get { return lookDirection; } }


    protected virtual void Awake() 
    {
        // 자식클래스들은 모두 rigidbody를 가짐
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    protected virtual void Start() 
    { }

    protected virtual void Update() 
    { }

    private void Movement() 
    {

    }

    private void Rotate() 
    {
    }
    
}
