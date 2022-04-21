using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redlight : MonoBehaviour
{
    public GameObject HandLight;

    // Start is called before the first frame update
    void Start()
    {
        HandLight = GameObject.Find("HandLight 2D");
        HandLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collide)
    {
   
        if (collide.gameObject.tag == "HandLight1")
        {
            Destroy(GameObject.Find("redHandLight1"));
            HandLight.SetActive(true);
            Destroy(GameObject.Find("redHandLight"));
        }


    }
}
