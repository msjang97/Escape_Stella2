using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOperationKey : MonoBehaviour //����Ű UI ��ũ��Ʈ
{

    public GameObject TargetPosition; //��������

    public GameObject ClickLabbor; //ó�� Ŭ�� ����
    private bool Labbor_UI_Bool; //uiŬ�� Ȯ�� �޾ƿ��� �Һ���
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Labbor_UI_Bool = ClickLabbor.GetComponent<ClickLabbor>().animator.GetBool("Bool_Labbor");
        
        if (Labbor_UI_Bool == true)
        {
            MoveUI();
        }
        else
            return;
    }

    private void MoveUI()
    {
        transform.position = Vector3.Lerp(gameObject.transform.position, TargetPosition.transform.position, 0.01f);
    }
}
