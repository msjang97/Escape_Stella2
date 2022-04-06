using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialDialog : MonoBehaviour
{
    public Text ChatText; // 실제 채팅이 나오는 텍스트
    public Text CharacterName; // 캐릭터 이름이 나오는 텍스트

    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

    public string writerText = ""; //

    bool isButtonClicked = false; //클릭버튼 체크

    private int CheckNum = 0;
    private GameObject Contents; //대사창 변수

    

    void Start()
    {
        StartCoroutine(TextPractice()); //코루틴 함수(TextPracice) 시작
        Contents = GameObject.Find("Contents");
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) //마우스 클릭이나 엔터키 누를때마다 체크
        {
            isButtonClicked = true;
            CheckNum++;
        }


    }

    IEnumerator NormalChat(string narrator, string narration) //원래는 캐릭터 이름도 쓰지만 쓰지않음.
    {
        int a = 0;
        CharacterName.text = narrator; 
        writerText = "";

        //텍스트 타이핑 한글자씩 출력함 효과
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a]; 
            ChatText.text = writerText;
            yield return new WaitForSeconds(0.05f); //속도조절
        }

        //키를 다시 누를 떄 까지 무한정 대기 , 키를 누를때까지 대사출력안함
        while (true)
        {
            if (isButtonClicked)
            {
                isButtonClicked = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextPractice() //대사입력 하는곳
    {   
        yield return StartCoroutine(NormalChat("", "여긴 어디지?"));
        yield return StartCoroutine(NormalChat("", "분명 영화관에 있었는데?"));
        yield return StartCoroutine(NormalChat("", "내가 왜 여기있는거야?"));
        yield return StartCoroutine(NormalChat("", "여기서 나가야겠어..."));
        yield return StartCoroutine(NormalChat("", "버튼을 눌러보자..."));
        yield return StartCoroutine(NormalChat("", " "));
    }
}
