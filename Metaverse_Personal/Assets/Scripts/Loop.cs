using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public int pipeCount = 0;
    public Vector3 pipeLastPosition = Vector3.zero;

    // 백그라운드 개수
    public int BgCount = 1;

    void Start()
    {
        Obstacles[] obstacles = GameObject.FindObjectsOfType<Obstacles>();

        pipeLastPosition = obstacles[0].transform.position;
        pipeCount = obstacles.Length;



        // 파이프 반복 랜덤 생성
        for (int i=0; i<pipeCount; i++)
        {
            pipeLastPosition = obstacles[i].RandomPipe(pipeLastPosition, pipeCount);

        }
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 배경 반복생성
        if (collision.CompareTag("Background"))
        {
            float widthOfBgObject = ((BoxCollider2D)collision).size.x; //box collder size만큼 생성
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject * BgCount;
            collision.transform.position = pos;
            return;
        }
        
        
        // 충돌했을때 파이프라면
        Obstacles pipe = collision.GetComponent<Obstacles>();
        if (pipe)
        {
            pipeLastPosition = pipe.RandomPipe(pipeLastPosition, pipeCount);
        }
    }
}
