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
        Vector3 MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5); //���콺 �����ǰ��� �޾ƿ´�
        this.transform.position = Camera.main.ScreenToWorldPoint(MousePos); //ī�޶� ȭ�� ��ǥ���� ������ǥ�� ��ȯ.        
    }
}
