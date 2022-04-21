using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    public int Button1_Count = 0; //클릭 세는 용도
    public Text CountText; //보여줄 텍스트

    // Start is called before the first frame update
    void Start()
    {
        CountText.text = "1";
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = Button1_Count.ToString();
        if (Button1_Count == 10)
        {
            Button1_Count = 0;
        }
    }

    public void Click() {
        Button1_Count++;
        //Debug.Log("count" + Button1_Count);
    }

}
