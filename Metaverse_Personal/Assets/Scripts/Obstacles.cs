using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacles : MonoBehaviour
{
    GameManager gameManager;
    
    public float highPosY = 1f;
    public float lowPosY = -1f;

    // ������ ���Ʒ� ���� ���� �ִ�/�ּ�
    public float holdSizeMin = 1f;
    public float holdSizeMax = 3f;

    // ������ �翷 ���� �ִ�/�ּ�
    public float minWidthPadding = 4f;
    public float maxWidthPadding = 10f;

    // ������ ���Ʒ�
    public Transform topPipe_Purple;
    
    public Transform bottomPipe_Purple;

    // ���������(�̱���)
    //public Transform bottomPipe_Yellow;
    //public Transform topPipe_Yellow;

    //����/��� �����ư��鼭 ���� (���� ����)
    // public bool isPurple = true;


    public float widthPadding = 10f;


    public void Start()
    {
        gameManager = GameManager.Instance;
    }

    // ������ ��������
    public Vector3 RandomPipe(Vector3 lastPositon, int pipeCount)
    {
        float holeSize = Random.Range(holdSizeMin, holdSizeMax);
        float halfHoleSize = holeSize / 2f;
           
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

        // ��������(����-��� �����ư��� ����) 
        //if (isPurple)
        // {
        // topPipe_Yellow.localPosition = new Vector3(0, halfHoleSize);
        // bottomPipe_Yellow.localPosition = new Vector3(0, -halfHoleSize);
        //isPurple = false;
        //}
  
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController_MiniGame player = collision.GetComponent<PlayerController_MiniGame>();
        if (player != null) { gameManager.AddScore(1); }
    }

}
