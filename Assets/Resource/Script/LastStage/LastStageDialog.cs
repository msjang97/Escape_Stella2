using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LastStageDialog : MonoBehaviour
{
    public Text ChatText; // 실제대사가 나오는 텍스트
    public GameObject Playerobject;


    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

    public string writerText = "";

    bool isButtonClicked = false;

    private int CheckNum = 0; // 몇번 버튼을 눌렀는지에 대한 확인버튼

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
        yield return StartCoroutine(NormalChat("거대한 문뿐이야..."));
        yield return StartCoroutine(NormalChat("도망칠 곳은 없나....?"));
        yield return StartCoroutine(NormalChat("아냐 포기하면 안돼"));
        yield return StartCoroutine(NormalChat("문을 움직일 순 없을까?"));
        
    }

    void SetOff()
    {
        this.gameObject.SetActive(false);
    }
}
