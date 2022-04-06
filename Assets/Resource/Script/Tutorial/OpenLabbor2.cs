using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLabbor2 : MonoBehaviour //다음 스테이지로 가기 위한 레버 및 발판 생성.
{
    private Animator animator;
    private bool OntriggerEnter = false;
    public bool OpenDoor1 = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //animator.SetBool("Bool_Set_On_Labbor2", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.gameObject.name == "Player" && OntriggerEnter == true)
        {
           
            animator.SetBool("Bool_Set_On_Labbor2", true);
            OpenDoor1 = true;
            Debug.Log(OpenDoor1);
        }
    }

    private void OnMouseUp()
    {
        OntriggerEnter = true;
    }


}
