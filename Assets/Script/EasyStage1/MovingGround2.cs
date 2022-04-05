using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround2 : MonoBehaviour
{
    float CurrentPosition2;
    float Xmax = 10.0f;
    float Xmin = -10.0f;
    float DirPower = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GroundMove2();
    }

    void GroundMove2()
    {
        CurrentPosition2 += Time.deltaTime * DirPower;
        if (CurrentPosition2 >= Xmax) 
        {
            DirPower *= -1;
            CurrentPosition2 = Xmax;
        }

        else if (CurrentPosition2 <= Xmin) 
        {
            DirPower *= -1;
            CurrentPosition2 = Xmin;
        }
        transform.position = new Vector3(CurrentPosition2, 0, -5.0f);
    }
}
