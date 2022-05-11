using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public GameObject LetterObj; //������

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
        Debug.Log("Ÿ�̸�:" + Timer);
        Vector3 MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5); //���콺 �����ǰ��� �޾ƿ´�
        this.transform.position = Camera.main.ScreenToWorldPoint(MousePos); //ī�޶� ȭ�� ��ǥ���� ������ǥ�� ��ȯ.
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
