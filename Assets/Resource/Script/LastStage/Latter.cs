using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latter : MonoBehaviour //���� ��ũ��Ʈ
{
    public GameObject MonsterObj; //�ʷϻ� ���� obj

    public GameObject PassWordObj; //��Ʈ�� ���� ���� obj
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(MonsterObj.transform.position.x, MonsterObj.transform.position.y, MonsterObj.transform.position.z);
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PassWordObj.SetActive(true);
        }
    }


}
