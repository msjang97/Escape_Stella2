using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour //��ǥ �������� ��ũ��Ʈ
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MusicNote"))
        {
            Debug.Log("��Ҿ��");
            Destroy(collision.gameObject);
        }

    }
}
