﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button5: MonoBehaviour
{
    public int Button5_Count = 0; //클릭 세는 용도
    public Text CountText; //보여줄 텍스트

    // Start is called before the first frame update
    void Start()
    {
        CountText.text = "5";
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = Button5_Count.ToString();
        if (Button5_Count == 10)
        {
            Button5_Count = 0;
        }
    }

    public void Click()
    {
        Button5_Count++;
        Debug.Log("count" + Button5_Count);
    }
}
