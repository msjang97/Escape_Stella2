using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button6 : MonoBehaviour
{
    public int Button6_Count = 0; //클릭 세는 용도
    public Text CountText; //보여줄 텍스트

    // Start is called before the first frame update
    void Start()
    {
        CountText.text = "6";
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = Button6_Count.ToString();
        if (Button6_Count == 10)
        {
            Button6_Count = 0;
        }
    }

    public void Click()
    {
        Button6_Count++;
        Debug.Log("count" + Button6_Count);
    }
}
