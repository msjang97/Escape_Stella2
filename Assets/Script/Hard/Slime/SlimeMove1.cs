using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMove1 : MonoBehaviour
{
    float Xmax = 23.4f;
    float Xmin = 6.5f;
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
            rend.flipX = true;
        }

        else if (currentPosition <= Xmin) //오른쪽 갈때 
        {
            direction *= -1;
            currentPosition = Xmin;
            rend.flipX = false;
        }

        transform.position = new Vector3(currentPosition, -14f, 0f);
    }

}
