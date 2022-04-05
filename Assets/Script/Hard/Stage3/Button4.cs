using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button4 : MonoBehaviour
{
    public int Button4_Count = 0; //클릭 세는 용도
    public Text CountText; //보여줄 텍스트

    // Start is called before the first frame update
    void Start()
    {
        CountText.text = "4";
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = Button4_Count.ToString();
        if (Button4_Count == 10)
        {
            Button4_Count = 0;
        }
    }

    public void Click()
    {
        Button4_Count++;
        Debug.Log("count" + Button4_Count);
    }
}
