using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLabbor : MonoBehaviour
{
 
    public Animator animator; //애니메이션 변수 적용
    public GameObject WallObj; //레버 클릭시 생기는 벽돌
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
        WallObj.SetActive(true); //벽돌obj활성화
    }


}
