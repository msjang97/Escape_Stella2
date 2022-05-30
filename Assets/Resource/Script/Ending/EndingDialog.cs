using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingDialog : MonoBehaviour
{
    public Text ChatText; // 실제대사가 나오는 텍스트

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
                SceneManager.LoadScene("Title"); // 타이틀로 이동.
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
        yield return StartCoroutine(NormalChat("돌아왔나...?"));
        yield return StartCoroutine(NormalChat("상영회를 이렇게 마칩니다!"));
        yield return StartCoroutine(NormalChat("스텔라님의 소감 듣고 마무리 하겠습니다"));
        yield return StartCoroutine(NormalChat("음... 다음 영화는 탈출 영화가 좋겠네요"));
        yield return StartCoroutine(NormalChat("다음에 더 좋은 영화로 돌아올게요"));
    }


}
