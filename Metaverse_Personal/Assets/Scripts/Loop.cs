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

        // ������ �ݺ� ���� ����
        for (int i=0; i<pipeCount; i++)
        {
            pipeLastPosition = obstacles[i].RandomPipe(pipeLastPosition, pipeCount);
        }
    }

}
