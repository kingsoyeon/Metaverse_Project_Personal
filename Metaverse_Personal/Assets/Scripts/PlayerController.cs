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
        // ����, ���� �Է�
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // �̵����� = Ű���� �Է�
        // �� ��(horizontal, vertical)�� 2D ���ͷ� �����ѵ�(ĳ���Ͱ� �̵��ؾ� �� ����)
        // ����ȭ(������ ũ�⸦ 1�� ���� = �̵��ӵ��� ������ ���� �ʰ�, ���⸸ ��Ÿ��)
        moveDirection = new Vector2(h, v).normalized;

        // �ٶ󺸴� ���� = ���콺 ��ġ
        Vector2 mousePosition = Input.mousePosition;

        // ���콺 ��ġ�� ���� ��ǥ�� ��ȯ
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);

        // �ٶ󺸴� ������ ĳ������ ��ġ-> ���� ��ǥ(���콺��ġ)
        lookDirection = (worldPos - (Vector2)transform.position);

        // �ʹ� �̼��ϸ� ��������
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
