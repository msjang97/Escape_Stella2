using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLabbor : MonoBehaviour
{
 
    public Animator animator; //�ִϸ��̼� ���� ����
    public GameObject WallObj; //���� Ŭ���� ����� ����
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Bool_Labbor", false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        animator.SetBool("Bool_Labbor", true);
        WallObj.SetActive(true); //����objȰ��ȭ
    }


}
