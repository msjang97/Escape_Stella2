using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MonsterText : MonoBehaviour
{
    public Text ChatText; // 실제대사가 나오는 텍스트

    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

    public string writerText = "";

    bool isButtonClicked = false;

    public GameObject GameManagerObj; //음표닿으면 부셔지는 오브젝트
    bool NowMusicPlaying = false; //Endpoint 스크립트에서 부셔진 음표개수 받아올 변수

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    void Update()
    {
        NowMusicPlaying = GameManagerObj.GetComponent<MusicCheck>().isplayingMusic;
        Debug.Log(NowMusicPlaying);
    }


    IEnumerator NormalChat(string narration)
    {
        int a = 0;
        writerText = "";

        //텍스트 타이핑 효과
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(0.05f);
        }

        //키를 다시 누를 떄 까지 무한정 대기
        while (true)
        {
            if (NowMusicPlaying == true)
            {
                //isButtonClicked = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("졸려... 잠들면 큰일나는데...."));
        yield return StartCoroutine(NormalChat("조금만 자야지....."));
    }
}
