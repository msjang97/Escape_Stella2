using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    public GameObject Bgm;
    GameObject BackgroundMusic;
    AudioSource backmusic;


    void Awake()
    {      
        BackgroundMusic = GameObject.Find("GameManager"); //게임매니저 찾아서 변수에 저장
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //변수의 오디오소스 속성 backmusic에 저장
        if (backmusic.isPlaying)
        {
            return;
        }

        else 
        {
            backmusic.Play();
            DontDestroyOnLoad(BackgroundMusic);
        }


    }

    // Start is called before the first frame update
    public void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

    }
}
