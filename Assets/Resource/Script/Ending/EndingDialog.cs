using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingDialog : MonoBehaviour
{
    public Text ChatText; // ������簡 ������ �ؽ�Ʈ

    public string writerText = "";

    bool isButtonClicked = false;

    private int CheckNum = 0; // ��� ��ư�� ���������� ���� Ȯ�ι�ư

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
                SceneManager.LoadScene("Title"); // Ÿ��Ʋ�� �̵�.
            }
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
        yield return StartCoroutine(NormalChat("���ƿԳ�...?"));
        yield return StartCoroutine(NormalChat("��ȸ�� �̷��� ��Ĩ�ϴ�!"));
        yield return StartCoroutine(NormalChat("���ڶ���� �Ұ� ��� ������ �ϰڽ��ϴ�"));
        yield return StartCoroutine(NormalChat("��... ���� ��ȭ�� Ż�� ��ȭ�� ���ڳ׿�"));
        yield return StartCoroutine(NormalChat("������ �� ���� ��ȭ�� ���ƿðԿ�"));
    }


}
