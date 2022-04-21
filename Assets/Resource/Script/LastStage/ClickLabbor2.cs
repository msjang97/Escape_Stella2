using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLabbor2 : MonoBehaviour //�������������� ���� ��ũ��Ʈ.
{
    private Animator animator; //�ִϸ��̼� ���� ����
    public bool OnoffLabbor = false;

    public GameObject NotificationObj;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Click_LastLabbor", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        animator.SetBool("Click_LastLabbor", true);
        OnoffLabbor = true;
        NotificationObj.SetActive(true);
        Invoke("DestroyLabbor", 4.0f);
    }

    void DestroyLabbor()
    {
        Destroy(gameObject);
    }
}
