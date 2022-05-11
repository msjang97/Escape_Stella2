using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAlpha : MonoBehaviour
{

    public GameObject GameManagerObj;
    bool MusicPlayingCheck = false; //MusicCheck 스크립트에서 "isplayingMusic" 상태 받아올 변수
    float Alphanum = 1.0f;

    float a = 1;

    public SpriteRenderer Spr;
    Color MonsterColor;
    // Start is called before the first frame update
    void Start()
    {
        Spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MusicPlayingCheck = GameManagerObj.GetComponent<MusicCheck>().isplayingMusic;

        if (MusicPlayingCheck == true)
        {
            while (true)
            {
                Alphanum = Alphanum - 0.001f;
                Spr.color = new Color(1, 1, 0.5f, Alphanum);
                if (Alphanum <= 0.0)
                {
                    Debug.Log("문제문제");
                }
                return;
            }
        }

        //{
        //    Alphanum = Alphanum - 0.01f;
        //    Spr.color = new Color(1, 1, 1, Alphanum);

        //}
        //Debug.Log(Alphanum);
    }
}
