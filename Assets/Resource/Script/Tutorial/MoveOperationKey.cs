using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOperationKey : MonoBehaviour //조작키 UI 스크립트
{

    public GameObject TargetPosition; //도착지점

    public GameObject ClickLabbor; //처음 클릭 레버
    private bool Labbor_UI_Bool; //ui클릭 확인 받아오는 불변수
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
