using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacles : MonoBehaviour
{
    
    public float highPosY = 1f;
    public float lowPosY = -9f;

    // ������ ���Ʒ� ���� ���� �ִ�/�ּ�
    public float holdSizeMin = 5f;
    public float holdSizeMax = 9f;

    // ������ �翷 ���� �ִ�/�ּ�
    public float minWidthPadding = 8f;
    public float maxWidthPadding = 12f;

    // ������ ���Ʒ�
    public Transform topPipe_Purple;
    //public Transform topPipe_Yellow;
    public Transform bottomPipe_Purple;
    //public Transform bottomPipe_Yellow;

    //����/��� �����ư��鼭
    public bool isPurple = true;


    public float widthPadding = 10f;
    
    // ������ ��������
    public Vector3 RandomPipe(Vector3 lastPositon, int pipeCount)
    {
        float holeSize = Random.Range(holdSizeMin, holdSizeMax);
        float halfHoleSize = holeSize / 2f;
        //if (isPurple)
       // {
           // topPipe_Yellow.localPosition = new Vector3(0, halfHoleSize);
           // bottomPipe_Yellow.localPosition = new Vector3(0, -halfHoleSize);
            //isPurple = false;
        //}
       
        
            topPipe_Purple.localPosition = new Vector3(0, halfHoleSize);
            bottomPipe_Purple.localPosition = new Vector3(0, -halfHoleSize);
        

        // ������ �翷���� ����
        float randomWidthPadding = Random.Range(minWidthPadding, maxWidthPadding);

        // ������ X��ǥ ������
        Vector3 pipePosition = lastPositon + new Vector3(randomWidthPadding, 0);

        // ������ y��ǥ ����
        pipePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = pipePosition;

        return pipePosition;

    }
}
