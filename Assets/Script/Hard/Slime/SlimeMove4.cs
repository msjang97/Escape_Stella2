using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMove4 : MonoBehaviour
{
    float Xmax = 25.7f;
    float Xmin = 15.3f;
    float currentPosition;

    public SpriteRenderer rend;

    float direction = 8.0f; //이동속도 및 방향


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

        transform.position = new Vector3(currentPosition, 4.2f, 0f);
    }
}
