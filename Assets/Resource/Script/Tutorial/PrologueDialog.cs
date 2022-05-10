using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrologueDialog : MonoBehaviour
{
    public Text ChatText; // 실제대사가 나오는 텍스트

    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

    public string writerText = "";

    bool isButtonClicked = false;

    private int CheckNum = 0; // 몇번 버튼을 눌렀는지에 대한 확인버튼

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isButtonClicked = true;
            CheckNum++;

            if (CheckNum == 5)
            {
                SceneManager.LoadScene("Tutorial"); // 튜토리얼 scene 이동.
            }
        }

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
            if (isButtonClicked)
            {
                isButtonClicked = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("(한 영화관 안)"));
        yield return StartCoroutine(NormalChat("상영회를 위해 오신 주연배우 스텔라님이 입장하고 계십니다!"));
        yield return StartCoroutine(NormalChat("반갑습니다. 여주인공 스텔라입니다."));
        yield return StartCoroutine(NormalChat("새 영화 기대해주세요!"));
        yield return StartCoroutine(NormalChat("피곤하네... 잠들면 안 되는데..."));
    }


}
