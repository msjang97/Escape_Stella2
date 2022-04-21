using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
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
        Vector3 MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5); //마우스 포지션값을 받아온다
        this.transform.position = Camera.main.ScreenToWorldPoint(MousePos); //카메라 화면 좌표값을 공간좌표로 변환.        
    }
}
