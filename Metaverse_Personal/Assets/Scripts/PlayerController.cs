using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : BaseController
{
    private Camera camera;

    protected override void Start()
    {
        base.Start();
        camera = Camera.main;

    }
    // Start is called before the first frame update
    protected override void HandleInput()
    {
        // 수평, 수직 입력
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // 이동방향 = 키보드 입력
        // 두 값(horizontal, vertical)을 2D 벡터로 결합한뒤(캐릭터가 이동해야 할 방향)
        // 정규화(벡터의 크기를 1로 만듦 = 이동속도에 영향을 주지 않고, 방향만 나타냄)
        moveDirection = new Vector2(h, v).normalized;

        // 바라보는 방향 = 마우스 위치
        Vector2 mousePosition = Input.mousePosition;

        // 마우스 위치를 월드 좌표로 변환
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);

        // 바라보는 방향은 캐릭터의 위치-> 월드 좌표(마우스위치)
        lookDirection = (worldPos - (Vector2)transform.position);

        // 너무 미세하면 변동없음
        if (lookDirection.magnitude < .9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }
    }


}
