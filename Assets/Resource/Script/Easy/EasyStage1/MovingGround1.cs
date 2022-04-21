using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround1 : MonoBehaviour
{
    float CurrentPosition1;
    float Xmax = 10.0f;
    float Xmin = -10.0f;
    float DirPower = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        CurrentPosition1 = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        GroundMove1();
    }

    void GroundMove1()
    {
        CurrentPosition1 += Time.deltaTime * DirPower;
        if (CurrentPosition1 >= Xmax) //왼쪽갈때
        {
            DirPower *= -1;
            CurrentPosition1 = Xmax;
        }

        else if (CurrentPosition1 <= Xmin) //오른쪽 갈때 
        {
            DirPower *= -1;
            CurrentPosition1 = Xmin;
        }
        transform.position = new Vector3(CurrentPosition1, 0, -20.0f);
    }

}
