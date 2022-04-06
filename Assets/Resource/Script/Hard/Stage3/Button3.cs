using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button3 : MonoBehaviour
{
    public int Button3_Count = 0; //클릭 세는 용도
    public Text CountText; //보여줄 텍스트

    // Start is called before the first frame update
    void Start()
    {
        CountText.text = "3";
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = Button3_Count.ToString();
        if (Button3_Count == 10)
        {
            Button3_Count = 0;
        }
    }

    public void Click()
    {
        Button3_Count++;
        Debug.Log("count" + Button3_Count);
    }
}
