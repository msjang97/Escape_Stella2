﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrologueDialog : MonoBehaviour
{
    public Text ChatText; // 실제 채팅이 나오는 텍스트
    public Text CharacterName; // 캐릭터 이름이 나오는 텍스트


    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

    public string writerText = "";

    bool isButtonClicked = false;

    private int CheckNum = 0;

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            //Debug.Log("눌렸음");
            isButtonClicked = true;
            CheckNum++;

            Debug.Log(CheckNum);
            if (CheckNum == 5)
            {
                SceneManager.LoadScene("Tutorial"); // 튜토리얼 scene 이동.
            }
        }

    }


    IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        CharacterName.text = narrator;
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
        yield return StartCoroutine(NormalChat("", "(한 영화관 앞)"));
        yield return StartCoroutine(NormalChat("", "개봉을 위해 오신 주연배우 스텔라님이 입장하고 계십니다!"));
        yield return StartCoroutine(NormalChat("", "반갑습니다. 여주인공 스텔라입니다."));
        yield return StartCoroutine(NormalChat("", "영화 시작 합니다!"));
        yield return StartCoroutine(NormalChat("", "피곤하네... 잠들면 안 되는데..."));
    }


}
