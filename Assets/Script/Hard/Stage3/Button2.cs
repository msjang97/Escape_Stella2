using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    public int Button2_Count = 0; //클릭 세는 용도
    public Text CountText; //보여줄 텍스트

    // Start is called before the first frame update
    void Start()
    {
        CountText.text = "2";
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = Button2_Count.ToString();
        if (Button2_Count == 10)
        {
            Button2_Count = 0;
        }
    }

    public void Click()
    {
        Button2_Count++;
        Debug.Log("count" + Button2_Count);
    }
}
