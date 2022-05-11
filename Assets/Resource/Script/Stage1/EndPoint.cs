using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour //음표 도착지점 스크립트
{
    public int EndPoint_DestoryNoteNum = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //EndPoint_DestoryNoteNum = MusicNoteobj.GetComponent<MusicCheck>().DestoryNoteNum;
       
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MusicNote"))
        {
            Destroy(collision.gameObject);
            EndPoint_DestoryNoteNum++;
        }


    }
}
