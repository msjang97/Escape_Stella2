using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2MonsterDialog : MonoBehaviour
{
    public Text ChatText; // 실제대사가 나오는 텍스트
    public GameObject MonsterObj;
    public GameObject PlayerObj;

    public string writerText = "";

    bool isButtonClicked = false;

    private int CheckNum = 0;

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 클릭 누를때마다 체크
        {
            isButtonClicked = true;
            CheckNum++;
        }

        if (CheckNum == 2)
        {
            DestoryText();
            MonsterObj.SetActive(false);
            PlayerObj.SetActive(true);
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
        yield return StartCoroutine(NormalChat("침입자다! 침입자다!"));
        yield return StartCoroutine(NormalChat("도움! 도움!"));
    }

    void DestoryText()
    {
        Destroy(ChatText);
    }

}
