using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clearcondition : MonoBehaviour //���ӸŴ������� Ŭ��������, ��������
{
    public GameObject EndPointObj; //��ǥ������ �μ����� ������Ʈ
    int DestoryNote_InClearcondition; //Endpoint ��ũ��Ʈ���� �μ��� ��ǥ���� �޾ƿ� ����

    public GameObject GameOvertxt; // ���ӿ����޼���



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

    void TimetoScale()  //Ÿ�� ������ ����
    {
        Time.timeScale = 0;
    }
}
