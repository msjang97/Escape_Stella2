using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCheck : MonoBehaviour //stage1 ���尡 ��� �� üũ 
{
    public GameObject ThisObj; //���Ӹ޴���obj
    public AudioSource audioSource; //������ҽ�

    public GameObject OpenDoorobj; // ������ obj
    public GameObject CloseDoorobj; // ������ obj

    public GameObject Monsterobj; //���� obj
    public GameObject MonsterTextobj; // ��� obj

    public GameObject MusicNoteobj; 

    // Start is called before the first frame update

    void Start()
    {
        AudioSource AudioSource = gameObject.GetComponent<AudioSource>();
        AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (audioSource.isPlaying == false)
        {
            Monsterobj.SetActive(false);
            MonsterTextobj.SetActive(false);
            OpenDoorobj.SetActive(true);
            CloseDoorobj.SetActive(false);
            MusicNoteobj.SetActive(false);
        }
        
    }
}
