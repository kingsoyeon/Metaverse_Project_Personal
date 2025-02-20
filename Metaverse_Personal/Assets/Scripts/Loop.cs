using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public int pipeCount = 0;
    public Vector3 pipeLastPosition = Vector3.zero;

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
        // 충돌했을때 파이프라면
        Obstacles pipe = collision.GetComponent<Obstacles>();
        if (pipe)
        {
            pipeLastPosition = pipe.RandomPipe(pipeLastPosition, pipeCount);
        }
    }
}
