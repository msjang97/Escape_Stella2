using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDoor : MonoBehaviour // �� ��ũ��Ʈ
{
    // Start is called before the first frame update
    public GameObject CloseDoor;
    public GameObject OpenDoor;

    public GameObject labbor2; //���� ���� ����
    public GameObject labbor3; //������ ���� ����

    private bool BoolDoorOpen1; //OpenLabbor2����  OpenDoor1 ���� �޾ƿ� ����
    private bool BoolDoorOpen2; //OpenLabbor3����  OpenDoor2 ���� �޾ƿ� ����

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
