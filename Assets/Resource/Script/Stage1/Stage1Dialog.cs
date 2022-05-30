using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1Dialog : MonoBehaviour //stage1�� ��ȭ
{
    public Text ChatText; // ������簡 ������ �ؽ�Ʈ
    public GameObject Playerobj;

    public List<KeyCode> skipButton; // ��ȭ�� ������ �ѱ� �� �ִ� Ű

    public string writerText = "";
    bool isButtonClicked = false;

    private int CheckNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextPractice());
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Playerobj.transform.position.x, Playerobj.transform.position.y+7, Playerobj.transform.position.z);
        if (Input.GetMouseButtonDown(0)) //���콺 Ŭ���̳� ����Ű ���������� üũ
        {
            isButtonClicked = true;
            CheckNum++;
        }

        if (CheckNum == 3)
        {
            Invoke("SetOff", 1.5f);
        }
    }

    IEnumerator NormalChat(string narration) //������ ĳ���� �̸��� ������ ��������.
    {
        int a = 0;
        writerText = "";

        //�ؽ�Ʈ Ÿ���� �ѱ��ھ� ����� ȿ��
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(0.05f); //�ӵ�����
        }

        //Ű�� �ٽ� ���� �� ���� ������ ��� , Ű�� ���������� �����¾���
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
        yield return StartCoroutine(NormalChat("���Ͱ� ���� ���� �־�"));
        yield return StartCoroutine(NormalChat("���� ����� ��������"));
        yield return StartCoroutine(NormalChat("��ħ �ǾƳ뵵 �ֳ�"));    
    }

    void SetOff()
    {
        this.gameObject.SetActive(false);
    }

    

}
