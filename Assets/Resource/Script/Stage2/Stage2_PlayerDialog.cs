using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2_PlayerDialog : MonoBehaviour
{
    public Text ChatText; // ������簡 ������ �ؽ�Ʈ
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
        if (Input.GetMouseButtonDown(0)) //���콺 Ŭ�� ���������� üũ
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
        yield return StartCoroutine(NormalChat("���ƾƾ�!!"));
        yield return StartCoroutine(NormalChat("�� �������°���?"));
        yield return StartCoroutine(NormalChat("�ڿ� ���� ����!!!"));
    }

    void DestoryText()
    {
        Destroy(ChatText);
    }

}
