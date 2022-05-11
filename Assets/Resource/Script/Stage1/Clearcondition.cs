using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clearcondition : MonoBehaviour //게임매니저에서 클리어조건, 종료조건
{
    public GameObject EndPointObj; //음표닿으면 부셔지는 오브젝트
    int DestoryNote_InClearcondition; //Endpoint 스크립트에서 부셔진 음표개수 받아올 변수

    public GameObject GameOvertxt; // 게임오버메세지



    // Start is called before the first frame update
    void Start()
    {
        GameOvertxt.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        DestoryNote_InClearcondition = EndPointObj.GetComponent<EndPoint>().EndPoint_DestoryNoteNum;
        if (DestoryNote_InClearcondition == 3)
        {
            GameOvertxt.SetActive(true);

            Invoke("TimetoScale", 2.0f);
            if (Input.GetKeyDown(KeyCode.F5))
            {
                SceneManager.LoadScene("Stage1");
                Time.timeScale = 1;
            }
        }
       
    }

    void TimetoScale()  //타임 스케일 조정
    {
        Time.timeScale = 0;
    }
}
