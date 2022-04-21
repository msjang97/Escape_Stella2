using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround3 : MonoBehaviour
{
     float CurrentPosition3;

    float Xmax = 10.0f;
    float Xmin = -10.0f;
    float DirPower = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        CurrentPosition3 = transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {

        GroundMove3();

    }

    void GroundMove3()
    {
        CurrentPosition3 += Time.deltaTime * DirPower;
        if (CurrentPosition3 >= Xmax) //왼쪽갈때
        {
            DirPower *= -1;
            CurrentPosition3 = Xmax;
        }

        else if (CurrentPosition3 <= Xmin) //오른쪽 갈때 
        {
            DirPower *= -1;
            CurrentPosition3 = Xmin;
        }
        transform.position = new Vector3(CurrentPosition3, 0, 10.0f);
    }

}
