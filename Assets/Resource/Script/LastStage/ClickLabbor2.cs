using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickLabbor2 : MonoBehaviour //마지막스테이지 레버 스크립트.
{
    private Animator animator; //애니메이션 변수 적용
    public bool OnoffLabbor = false;

    public GameObject NotificationObj; //알림판 및 번호입력판

    public GameObject MonsterObj; //몬스터
    public GameObject MonsterTextObj; //몬스터대사창


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
        MonsterObj.SetActive(true);
        MonsterTextObj.SetActive(true);
        Invoke("DestroyLabbor", 4.0f) ;
    }

    void DestroyLabbor()
    {
        Destroy(gameObject);
    }
}
