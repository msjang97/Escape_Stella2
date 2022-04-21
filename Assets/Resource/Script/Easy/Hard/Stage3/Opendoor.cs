using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
    public int Button1_num;
    public int Button2_num;
    public int Button3_num;
    public int Button4_num;
    public int Button5_num;
    public int Button6_num;

    public GameObject Door2Obj;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Button1_num = GameObject.Find("Button1").GetComponent<Button1>().Button1_Count;
        Button2_num = GameObject.Find("Button2").GetComponent<Button2>().Button2_Count;
        Button3_num = GameObject.Find("Button3").GetComponent<Button3>().Button3_Count;
        Button4_num = GameObject.Find("Button4").GetComponent<Button4>().Button4_Count;
        Button5_num = GameObject.Find("Button5").GetComponent<Button5>().Button5_Count;
        Button6_num = GameObject.Find("Button6").GetComponent<Button6>().Button6_Count;
        Debug.Log("버튼1의 숫자" + Button1_num);
        DoorMove();
    }

    private void DoorMove()
    {
        if (Button1_num == 9 && Button2_num == 7 && Button3_num == 0 && Button4_num == 7 && Button5_num == 0 && Button6_num == 5)
        {
            Door2Obj.SetActive(true);
        }
    }
}
