using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResPawnMusicNote : MonoBehaviour
{
    public GameObject[] Note = new GameObject[4]; //음표 4개 이미지
    public GameObject RespawnPos1;
    public GameObject RespawnPos2;
    public GameObject RespawnPos3;
    public GameObject RespawnPos4;

    private Vector3 SpwanPos;


    private int RandomRespawnNum = 0;
    private int RandomImageNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ResPawn_Coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ResPawn_Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            RandomRespawnNum = Random.Range(0, 4);
            if (RandomRespawnNum == 0)
            {
                // Vector3 SpwanPos = new Vector3(32.0f, 17.0f, 0);
                SpwanPos = new Vector3(RespawnPos1.gameObject.transform.position.x, RespawnPos1.gameObject.transform.position.y, 0);
            }
            else if (RandomRespawnNum == 1)
            {
                SpwanPos = new Vector3(RespawnPos2.gameObject.transform.position.x, RespawnPos2.gameObject.transform.position.y, 0);
            }

            else if (RandomRespawnNum == 2)
            {
                SpwanPos = new Vector3(RespawnPos3.gameObject.transform.position.x, RespawnPos3.gameObject.transform.position.y, 0);
            }

            else if (RandomRespawnNum == 3)
            {
                SpwanPos = new Vector3(RespawnPos4.gameObject.transform.position.x, RespawnPos4.gameObject.transform.position.y, 0);
            }

            RandomImageNum = Random.Range(0, Note.Length);
            Instantiate(Note[RandomImageNum], SpwanPos, Note[RandomImageNum].transform.rotation);
        }
    }
}
