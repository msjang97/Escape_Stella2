using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    float Xmax = 20.0f;
    float Xmin = 0.0f;
    float currentPosition;

    public SpriteRenderer rend;
    float direction = 15.0f; //이동속도 및 방향


    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position.x;
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition += Time.deltaTime * direction;
        if (currentPosition >= Xmax) //왼쪽갈때
        {
            direction *= -1;
            currentPosition = Xmax;
            rend.flipX = false;
        }

        else if (currentPosition <= Xmin) //오른쪽 갈때 
        {
            direction *= -1;
            currentPosition = Xmin;
            rend.flipX = true;
        }

        transform.position = new Vector3(currentPosition, 12.3f, 0.0f);
    }

}
