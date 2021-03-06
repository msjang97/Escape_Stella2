using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public GameObject LetterObj; //편지지

    //private bool boolDrop = false;
    public float Timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        
        Timer += Time.deltaTime;
        Vector3 MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5); //마우스 포지션값을 받아온다
        this.transform.position = Camera.main.ScreenToWorldPoint(MousePos); //카메라 화면 좌표값을 공간좌표로 변환.
       
        if (Timer > 3.0f)
        {
            DropLatter();
        }
        
    }

    private void OnMouseUp()
    {
        Timer = 0.0f;
    }


    void DropLatter() {
        LetterObj.SetActive(true);
    }

}
