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

    // 파이프 위아래 사이 간격 최대/최소
    public float holdSizeMin = 1f;
    public float holdSizeMax = 3f;

    // 파이프 양옆 간격 최대/최소
    public float minWidthPadding = 4f;
    public float maxWidthPadding = 10f;

    // 파이프 위아래
    public Transform topPipe_Purple;
    
    public Transform bottomPipe_Purple;

    // 노란파이프(미구현)
    //public Transform bottomPipe_Yellow;
    //public Transform topPipe_Yellow;

    //퍼플/노랑 번갈아가면서 출현 (구현 예정)
    // public bool isPurple = true;


    public float widthPadding = 10f;


    public void Start()
    {
        gameManager = GameManager.Instance;
    }

    // 파이프 랜덤생성
    public Vector3 RandomPipe(Vector3 lastPositon, int pipeCount)
    {
        float holeSize = Random.Range(holdSizeMin, holdSizeMax);
        float halfHoleSize = holeSize / 2f;
           
            topPipe_Purple.localPosition = new Vector3(0, halfHoleSize);
            bottomPipe_Purple.localPosition = new Vector3(0, -halfHoleSize);
        

        // 파이프 양옆간격 랜덤
        float randomWidthPadding = Random.Range(minWidthPadding, maxWidthPadding);

        // 파이프 X좌표 포지션
        Vector3 pipePosition = lastPositon + new Vector3(randomWidthPadding, 0);

        // 파이프 y좌표 랜덤
        pipePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = pipePosition;

        return pipePosition;

        // 구현예정(보라-노랑 번갈아가며 출현) 
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
