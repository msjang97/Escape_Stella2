using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNote : MonoBehaviour //��ǥ ��ũ��Ʈ
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.05f, 0.0f, 0.0f); // ��ǥ �ӵ� ����
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EndPoint"))
        {
            Debug.Log("��Ҿ��");
            Destroy(this.gameObject);
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("�÷��̾��Ҿ��");
            Destroy(this.gameObject);
        }

    }
}
