using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCheck : MonoBehaviour //stage1 자장가 재생 및 체크 
{
    public GameObject ThisObj; //게임메니저obj
    public AudioSource audioSource; //오디오소스

    public GameObject OpenDoorobj; // 단힌문 obj
    public GameObject CloseDoorobj; // 열린문 obj

    public GameObject Monsterobj; //몬스터 obj
    public GameObject MonsterTextobj; // 대사 obj

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
