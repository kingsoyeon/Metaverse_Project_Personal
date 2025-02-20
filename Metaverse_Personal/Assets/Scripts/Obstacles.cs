using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacles : MonoBehaviour
{
    
    public float highPosY = 1f;
    public float lowPosY = -1f;

    // ������ ���� ���� �ִ�/�ּ�
    public float holdSizeMin = 1f;
    public float holdSizeMax = 3f;

    // ������ ���Ʒ�
    public Transform topPipe_Purple;
    public Transform topPipe_Yellow;
    public Transform bottomPipe_Purple;
    public Transform bottomPipe_Yellow;


    public float widthPadding = 4f;
    
    // ������ ��������
    public Vector3 RandomPipe(Vector3 lastPositon, int pipeCount)
    {
        float holeSize = Random.Range(holdSizeMin, holdSizeMax);
        float halfHoleSize = holeSize / 2f;
        topPipe_Purple.localPosition = new Vector3(0, halfHoleSize);
        bottomPipe_Purple.localPosition = new Vector3(0, -halfHoleSize);
        topPipe_Yellow.localPosition = new Vector3(0, halfHoleSize);
        bottomPipe_Yellow.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 pipePosition = lastPositon + new Vector3(widthPadding, 0);
        pipePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = pipePosition;

        return pipePosition;

    }
}
