using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2_PlayerDialog : MonoBehaviour
{
    public Text ChatText; // 실제대사가 나오는 텍스트
    public GameObject Timemap2;
    public bool StartMonster = false;

    public GameObject Playerobject;

    public string writerText = "";

    bool isButtonClicked = false;

    private int CheckNum = 0;

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    void Update()
    {
        this.transform.position = new Vector3(Playerobject.transform.position.x, Playerobject.transform.position.y + 7, Playerobject.transform.position.z);
        if (Input.GetMouseButtonDown(0)) //마우스 클릭 누를때마다 체크
        {
            isButtonClicked = true;
            CheckNum++;
        }

        if (CheckNum == 3)
        {
            DestoryText();
            StartMonster = true;
            Timemap2.SetActive(false);
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
        yield return StartCoroutine(NormalChat("꺄아아악!!"));
        yield return StartCoroutine(NormalChat("왜 도망가는거지?"));
        yield return StartCoroutine(NormalChat("뒤에 뭐야 저건!!!"));
    }

    void DestoryText()
    {
        Destroy(ChatText);
    }

}
