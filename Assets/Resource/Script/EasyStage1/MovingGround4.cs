using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround4 : MonoBehaviour
{


    float CurrentPosition1;
    float CurrentPosition2;
    float CurrentPosition3;
    float CurrentPosition4;
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
        GroundMove4();
    }

 
    void GroundMove4()
    {
        CurrentPosition4 += Time.deltaTime * DirPower;
        if (CurrentPosition4 >= Xmax) //왼쪽갈때
        {
            DirPower *= -1;
            CurrentPosition4 = Xmax;
        }

        else if (CurrentPosition4 <= Xmin) //오른쪽 갈때 
        {
            DirPower *= -1;
            CurrentPosition4 = Xmin;
        }
        transform.position = new Vector3(CurrentPosition4, 0, 25.0f);
    }
}
