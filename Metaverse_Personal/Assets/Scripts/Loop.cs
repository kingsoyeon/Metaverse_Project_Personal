using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public int pipeCount = 0;
    public Vector3 pipeLastPosition = Vector3.zero;

    // ��׶��� ����
    public int BgCount = 1;

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

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ��� �ݺ�����
        if (collision.CompareTag("Background"))
        {
            float widthOfBgObject = ((BoxCollider2D)collision).size.x; //box collder size��ŭ ����
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject * BgCount;
            collision.transform.position = pos;
            return;
        }
        
        
        // �浹������ ���������
        Obstacles pipe = collision.GetComponent<Obstacles>();
        if (pipe)
        {
            pipeLastPosition = pipe.RandomPipe(pipeLastPosition, pipeCount);
        }
    }
}
