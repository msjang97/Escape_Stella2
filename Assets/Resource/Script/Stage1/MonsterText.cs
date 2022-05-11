using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MonsterText : MonoBehaviour
{
    public Text ChatText; // ������簡 ������ �ؽ�Ʈ

    public List<KeyCode> skipButton; // ��ȭ�� ������ �ѱ� �� �ִ� Ű

    public string writerText = "";

    bool isButtonClicked = false;

    public GameObject GameManagerObj; //��ǥ������ �μ����� ������Ʈ
    bool NowMusicPlaying = false; //Endpoint ��ũ��Ʈ���� �μ��� ��ǥ���� �޾ƿ� ����

    void Start()
    {
        StartCoroutine(TextPractice());
    }

    void Update()
    {
        NowMusicPlaying = GameManagerObj.GetComponent<MusicCheck>().isplayingMusic;
        Debug.Log(NowMusicPlaying);
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
            if (NowMusicPlaying == true)
            {
                //isButtonClicked = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("����... ���� ū�ϳ��µ�...."));
        yield return StartCoroutine(NormalChat("���ݸ� �ھ���....."));
    }
}
