using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMove5 : MonoBehaviour
{
    float Xmax = 28.0f;
    float Xmin = 23.7f;
    float currentPosition;


    public SpriteRenderer rend;

    float direction = 2.0f; //이동속도 및 방향


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
        if (currentPosition >= Xmax)
        {
            direction *= -1;
            currentPosition = Xmax;
            rend.flipX = true;
        }

        else if (currentPosition <= Xmin)
        {
            direction *= -1;
            currentPosition = Xmin;
            rend.flipX = false;
        }

        transform.position = new Vector3(currentPosition, 13.2f, 0f);
    }
}
