using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float smoothTimeX, smoothTimeY;
    public Vector2 velocity;
    public GameObject player;
    public Vector2 MinPos, MaxPos;
    public bool bound;

    
    // 캐릭터 초기화
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }



    // 캐릭터 위치에 따라 카메라가 부드럽게 이동하도록 하기
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);      
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);      
        transform.position = new Vector3(posX, posY, transform.position.z);

        if (bound)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, MinPos.x, MaxPos.x),
            Mathf.Clamp(transform.position.y, MinPos.y, MaxPos.y),
            Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z)
            );
        }

    }
}
