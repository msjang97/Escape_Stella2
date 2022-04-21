using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text[] TimerText;

    float TimeSet = 300;
    int Min, Second;

    
    // Start is called before the first frame update


    void Start()
    {
        TimerText[0].text = "05";
        TimerText[1].text = "00";
    }

    // Update is called once per frame
    void Update()
    {
        TimeSet -= Time.deltaTime;


        Min = (int)TimeSet / 60;
        Second = ((int)TimeSet - Min * 60) % 60;

        if (Min <= 0 && Second <= 0)
        {
            TimerText[0].text = 0.ToString();
            TimerText[1].text = 0.ToString();
        }

        else
        {
            if (Second >= 60)
            {
                Min += 1;
                Second -= 60;
            }
            else
            {
                TimerText[0].text = Min.ToString();
                TimerText[1].text = Second.ToString();
            }
        }

    }
}
