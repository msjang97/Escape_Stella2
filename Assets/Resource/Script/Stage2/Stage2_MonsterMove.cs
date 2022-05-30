using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_MonsterMove : MonoBehaviour
{
    private bool StartMoving = false;
    public GameObject Gameamanager;
    // Start is called before the first frame update
    void Start()
    {
        StartMoving = Gameamanager.GetComponent<Stage2_PlayerDialog>().StartMonster;
    }

    // Update is called once per frame
    void Update()
    {
        StartMoving = Gameamanager.GetComponent<Stage2_PlayerDialog>().StartMonster;
        if (StartMoving)
            this.transform.Translate(27.0f*Time.deltaTime, 0f, 0f);
    }
}
