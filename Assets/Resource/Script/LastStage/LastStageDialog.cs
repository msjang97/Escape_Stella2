using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LastStageDialog : MonoBehaviour
{
    public Text ChatText; // ������簡 ������ �ؽ�Ʈ
    public GameObject Playerobject;


    public List<KeyCode> skipButton; // ��ȭ�� ������ �ѱ� �� �ִ� Ű

    public string writerText = "";

    bool isButtonClicked = false;

    private int CheckNum = 0; // ��� ��ư�� ���������� ���� Ȯ�ι�ư

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    void Update()
    {
        this.transform.position = new Vector3(Playerobject.transform.position.x, Playerobject.transform.position.y + 7, Playerobject.transform.position.z);
        if (Input.GetMouseButtonDown(0))
        {
            isButtonClicked = true;
            CheckNum++;

            if (CheckNum == 4)
            {
                Invoke("SetOff", 1.5f);
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
        yield return StartCoroutine(NormalChat("�Ŵ��� �����̾�..."));
        yield return StartCoroutine(NormalChat("����ĥ ���� ����....?"));
        yield return StartCoroutine(NormalChat("�Ƴ� �����ϸ� �ȵ�"));
        yield return StartCoroutine(NormalChat("���� ������ �� ������?"));
        
    }

    void SetOff()
    {
        this.gameObject.SetActive(false);
    }
}
