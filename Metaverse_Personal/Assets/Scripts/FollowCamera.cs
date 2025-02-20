using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowCamera : MonoBehaviour
{
    
    public Transform miniGameCat; // 미니게임 플레이어
    float offsetX;

    // Start is called before the first frame update
    void Start()
    {
        if (miniGameCat == null) return;

        offsetX = transform.position.x- miniGameCat.position.x; // 간격은 카메라 위치 - 플레이어 위치만큼 (음수)
    }

    
    void Update()
    {
        if(miniGameCat == null) return;

        Vector3 pos = transform.position; // pos에 카메라 위치 저장
        pos.x = miniGameCat.position.x + offsetX; // 음수를 더하므로 왼쪽에서 따라옴
        transform.position = pos; // 바뀐 x좌표 다시 저장
    }
}
