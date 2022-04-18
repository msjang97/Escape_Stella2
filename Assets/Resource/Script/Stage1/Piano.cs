using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public GameObject BackGround2; //악보지
    public GameObject MusicNote; //음표 리스폰 오브젝트
    public GameObject NoteWall; //음표 나오는 곳 발판 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BackGround2.SetActive(true);
            MusicNote.SetActive(true);
            NoteWall.SetActive(true);
        }
    }
}
