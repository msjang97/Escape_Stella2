using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject Endpoint_Obj; //엔드포인트 obj
    public int MusicDeathCount = 0;

    private Rigidbody2D rigid; //플레이어 캐릭터 Rigidbody속성을 받아올 변수

    Animator animator; //애니메이션

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponentInChildren<Animator>();
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MusicDeathCount = Endpoint_Obj.GetComponent<EndPoint>().EndPoint_DestoryNoteNum;

        if (MusicDeathCount == 3) { 
            Death();
        }
    }

    void Death()
    {     
            animator.SetBool("Bool_Death", true);
    }
}
