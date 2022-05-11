using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCheck : MonoBehaviour //stage1 자장가 재생 및 체크 
{
    public GameObject ThisObj; //게임메니저obj
    public AudioSource audioSource; //오디오소스

    public GameObject OpenDoorobj; // 단힌문 obj
    public GameObject CloseDoorobj; // 열린문 obj

    public GameObject MusicNoteobj;

    public bool isplayingMusic = false;
    Color MonsterColor; //몬스터 컬러
    // Start is called before the first frame update

    void Start()
    {
        AudioSource AudioSource = gameObject.GetComponent<AudioSource>();
        AudioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {

        if (audioSource.isPlaying == false) //음표 미니게임을 클리어 하면
        {
            isplayingMusic = true;
            OpenDoorobj.SetActive(true);
            CloseDoorobj.SetActive(false);
            MusicNoteobj.SetActive(false);
        }
        
        
    }
}
