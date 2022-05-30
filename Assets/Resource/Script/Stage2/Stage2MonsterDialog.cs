using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2MonsterDialog : MonoBehaviour
{
    public Text ChatText; // ������簡 ������ �ؽ�Ʈ
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
        if (Input.GetMouseButtonDown(0)) //���콺 Ŭ�� ���������� üũ
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

        //�ؽ�Ʈ Ÿ���� ȿ��
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(0.05f);
        }

        //Ű�� �ٽ� ���� �� ���� ������ ���
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
        yield return StartCoroutine(NormalChat("ħ���ڴ�! ħ���ڴ�!"));
        yield return StartCoroutine(NormalChat("����! ����!"));
    }

    void DestoryText()
    {
        Destroy(ChatText);
    }

}
