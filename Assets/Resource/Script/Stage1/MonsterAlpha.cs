using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAlpha : MonoBehaviour
{

    public GameObject GameManagerObj;
    bool MusicPlayingCheck = false; //MusicCheck ��ũ��Ʈ���� "isplayingMusic" ���� �޾ƿ� ����
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
                    Debug.Log("��������");
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
