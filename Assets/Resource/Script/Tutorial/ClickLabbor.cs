using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLabbor : MonoBehaviour
{
    public Animator animator; //�ִϸ��̼� ���� ����
    public GameObject OnSetBlock; //���� Ŭ���� ����� ����
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Bool_Labbor", false); 
        OnSetBlock.SetActive(false); //�����Ⱥ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        print("�������ϴ�");
        animator.SetBool("Bool_Labbor", true);
        OnSetBlock.SetActive(true); //���� ����

    }


}
