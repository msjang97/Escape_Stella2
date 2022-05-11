using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject Endpoint_Obj; //��������Ʈ obj
    public int MusicDeathCount = 0;

    private Rigidbody2D rigid; //�÷��̾� ĳ���� Rigidbody�Ӽ��� �޾ƿ� ����

    Animator animator; //�ִϸ��̼�

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
