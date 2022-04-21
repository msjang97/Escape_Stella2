using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDoor : MonoBehaviour // 문 스크립트
{
    // Start is called before the first frame update
    public GameObject CloseDoor;
    public GameObject OpenDoor;

    public GameObject labbor2; //왼쪽 생성 레버
    public GameObject labbor3; //오른쪽 생성 레버

    private bool BoolDoorOpen1; //OpenLabbor2에서  OpenDoor1 변수 받아올 변수
    private bool BoolDoorOpen2; //OpenLabbor3에서  OpenDoor2 변수 받아올 변수

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BoolDoorOpen1 = labbor2.GetComponent<OpenLabbor2>().OpenDoor1;
        BoolDoorOpen2 = labbor3.GetComponent<OpenLabbor3>().OpenDoor2;   

        if (BoolDoorOpen1 == true && BoolDoorOpen2 == true)
        {
            CloseDoor.SetActive(false);
            OpenDoor.SetActive(true);
        }
    }
}
