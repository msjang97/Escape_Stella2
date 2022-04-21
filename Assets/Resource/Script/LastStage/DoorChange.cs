using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorChange : MonoBehaviour
{
    public GameObject EndPoint; //�� ������ ��ġ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(gameObject.transform.position, EndPoint.transform.position, 0.01f);
        
    }

  

}
