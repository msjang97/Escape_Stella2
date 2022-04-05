using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Handlight : MonoBehaviour
{
    private Transform playerpos; // 플레이어 포지션 받아올 변수.

    private GameObject Slime1; //몬스터1
    private GameObject Slime2; //몬스터2
    private GameObject Slime3; //몬스터3
    private GameObject Slime4; //몬스터4
    private GameObject Slime5; //몬스터5
    private GameObject Slime6; //몬스터6

    public Image BlackLightBackGround; 
    public Sprite ChangeSprite1; //오른쪽 라이트 사진
    public Sprite ChangeSprite2; //왼쪽 라이트 사진

    // Start is called before the first frame update

    void Start()
    {      
        Slime1 = GameObject.Find("Slime1");
        Slime2 = GameObject.Find("Slime2");
        Slime3 = GameObject.Find("Slime3");
        Slime4 = GameObject.Find("Slime4");
        Slime5 = GameObject.Find("Slime5");
        Slime6 = GameObject.Find("Slime6");
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // 플레이어 태그 단 오브젝트의 위치저장
        playerpos = GameObject.FindWithTag("Player").GetComponent<Transform>();
        if (Input.GetKeyDown(KeyCode.A))
        {
            BlackLightBackGround.sprite = ChangeSprite2;
          
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -180.0f);    // 180도로 콜라이더를 반전시킴
            Debug.Log("왼쪽");
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            BlackLightBackGround.sprite = ChangeSprite1;
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f); // 각도 원상태로 조절          
            Debug.Log("오른쪽");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag.Equals("HandLight")) {
            gameObject.SetActive(true);  
        }

        else if (collision.gameObject.name =="Slime1")
        {
            Debug.Log("슬라임1닿음");
            Destroy(Slime1);
        }
        else if (collision.gameObject.name == "Slime2")
        {
            Debug.Log("슬라임2닿음");
            Destroy(Slime2);
        }
        else if (collision.gameObject.name == "Slime3")
        {
            Debug.Log("슬라임3닿음");
            Destroy(Slime3);
        }
        else if (collision.gameObject.name == "Slime4")
        {
            Debug.Log("슬라임4닿음");
            Destroy(Slime4);
        }
        else if (collision.gameObject.name == "Slime5")
        {
            Debug.Log("슬라임5닿음");
            Destroy(Slime5);
        }
        else if (collision.gameObject.name == "Slime6")
        {
            Debug.Log("슬라임6닿음");
            Destroy(Slime6);
        }
    }



}
