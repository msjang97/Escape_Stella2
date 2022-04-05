using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMove3 : MonoBehaviour
{
    float Xmax = -5.5f;
    float Xmin = -11.6f;
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
            rend.flipX = false;
        }

        else if (currentPosition <= Xmin)
        {
            direction *= -1;
            currentPosition = Xmin;
            rend.flipX = true;
        }

        transform.position = new Vector3(currentPosition, 1.2f, 0.0f);
    }
}
