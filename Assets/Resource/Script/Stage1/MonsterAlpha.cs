using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAlpha : MonoBehaviour
{

    public GameObject GameManagerObj;
    bool MusicPlayingCheck = false; //MusicCheck ��ũ��Ʈ���� "isplayingMusic" ���� �޾ƿ� ����
    public float Alphanum = 1.0f;

    public SpriteRenderer Spr;

    

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
                Alphanum = Alphanum - (Time.deltaTime / 2.0f);
                Spr.color = new Color(1, 1, 0.5f, Alphanum);
                return;
            }
        }
    }
}
