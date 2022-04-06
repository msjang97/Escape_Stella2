using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLabbor : MonoBehaviour
{
    public Animator animator; //애니메이션 변수 적용
    public GameObject OnSetBlock; //레버 클릭시 생기는 벽돌
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Bool_Labbor", false); 
        OnSetBlock.SetActive(false); //벽돌안보임
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        print("눌렀습니다");
        animator.SetBool("Bool_Labbor", true);
        OnSetBlock.SetActive(true); //벽돌 보임

    }


}
