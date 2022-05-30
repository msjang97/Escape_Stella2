using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1Dialog : MonoBehaviour //stage1의 대화
{
    public Text ChatText; // 실제대사가 나오는 텍스트
    public GameObject Playerobj;

    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

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
        if (Input.GetMouseButtonDown(0)) //마우스 클릭이나 엔터키 누를때마다 체크
        {
            isButtonClicked = true;
            CheckNum++;
        }

        if (CheckNum == 3)
        {
            Invoke("SetOff", 1.5f);
        }
    }

    IEnumerator NormalChat(string narration) //원래는 캐릭터 이름도 쓰지만 쓰지않음.
    {
        int a = 0;
        writerText = "";

        //텍스트 타이핑 한글자씩 출력함 효과
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(0.05f); //속도조절
        }

        //키를 다시 누를 떄 까지 무한정 대기 , 키를 누를때까지 대사출력안함
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
        yield return StartCoroutine(NormalChat("몬스터가 길을 막고 있어"));
        yield return StartCoroutine(NormalChat("잠들게 만들고 지나가자"));
        yield return StartCoroutine(NormalChat("마침 피아노도 있네"));    
    }

    void SetOff()
    {
        this.gameObject.SetActive(false);
    }

    

}
