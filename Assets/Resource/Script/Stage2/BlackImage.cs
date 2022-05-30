using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackImage : MonoBehaviour
{

    public GameObject imageobj; //검정 이미지 obj
    public Color BlackImageobj;
    // Start is called before the first frame update
 
    void Start()
    {
        BlackImageobj = imageobj.GetComponent<Image>().color;
        
    }

    // Update is called once per frame
    void Update()
    {
        BlackImageobj.a -= 0.5f*Time.deltaTime;
        imageobj.GetComponent<Image>().color = BlackImageobj;

        if (BlackImageobj.a <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }



}
