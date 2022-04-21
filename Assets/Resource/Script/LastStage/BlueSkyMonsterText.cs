using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSkyMonsterText : MonoBehaviour
{
    public GameObject MonsterObj;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(MonsterObj.transform.position.x, MonsterObj.transform.position.y+5, MonsterObj.transform.position.z);
        Invoke("DestoryObj", 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(MonsterObj.transform.position.x, MonsterObj.transform.position.y + 5, MonsterObj.transform.position.z);
    }

    void DestoryObj()
    {
        Destroy(gameObject);
    }
}
