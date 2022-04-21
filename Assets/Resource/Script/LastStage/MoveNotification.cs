using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNotification : MonoBehaviour
{
    public GameObject TargetPosition; //��������

    public GameObject Labbor; //���� 
    private bool Labbor_UI_Bool = false;//����Ŭ�� Ȯ�� �޾ƿ��� �Һ���

    // Start is called before the first frame update
    private void Awake()
    {
        Labbor_UI_Bool = GameObject.Find("Labbor1").GetComponent<ClickLabbor2>().OnoffLabbor;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Labbor_UI_Bool == true)
        {
            MoveUI();
        }
    }

    private void MoveUI()
    {
        transform.position = Vector3.Lerp(gameObject.transform.position, TargetPosition.transform.position, 0.01f);
    }
}
