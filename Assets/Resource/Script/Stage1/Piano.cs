using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public GameObject BackGround2; //�Ǻ���
    public GameObject MusicNote; //��ǥ ������ ������Ʈ
    public GameObject NoteWall; //��ǥ ������ �� ���� 
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
