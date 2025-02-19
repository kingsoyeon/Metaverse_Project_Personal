using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    
    protected Rigidbody2D _rigidbody;

    // 스프라이트 렌더러 
    [SerializeField] private SpriteRenderer characterRenderer;

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
        // 방향벡터 * 숫자 = 크기(속도)
        direction = direction * 5;
        
        // rigidbody의 속도
        // direction에 따라 속도가 정해짐
        // 만약 (1,0)이면 속도는 1
        _rigidbody.velocity = direction;
    }

    private void Rotate(Vector2 direction) 
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // 90f가 넘는다면 왼편을 바라봄
        bool isLeft = Mathf.Abs(rotZ) > 90f;

        characterRenderer.flipX = isLeft;
    }
    
}
