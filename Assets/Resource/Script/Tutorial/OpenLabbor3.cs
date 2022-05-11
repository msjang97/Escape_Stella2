using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLabbor3 : MonoBehaviour
{
    private Animator animator;
    bool OntriggerEnter = false;
    public bool OpenDoor2 = false;
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
            animator.SetBool("Bool_Set_On_labbor3", true);
            OpenDoor2 = true;
        }
    }

    private void OnMouseUp()
    {
        OntriggerEnter = true;
    }
}
