using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowCamera : MonoBehaviour
{
    
    public Transform miniGameCat; // �̴ϰ��� �÷��̾�
    float offsetX;

    // Start is called before the first frame update
    void Start()
    {
        if (miniGameCat == null) return;

        offsetX = transform.position.x- miniGameCat.position.x; // ������ ī�޶� ��ġ - �÷��̾� ��ġ��ŭ (����)
    }

    
    void Update()
    {
        if(miniGameCat == null) return;

        Vector3 pos = transform.position; // pos�� ī�޶� ��ġ ����
        pos.x = miniGameCat.position.x + offsetX; // ������ ���ϹǷ� ���ʿ��� �����
        transform.position = pos; // �ٲ� x��ǥ �ٽ� ����
    }
}
