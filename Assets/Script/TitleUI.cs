using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleUI : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
  
    // Start is called before the first frame update
    void Start()
    {
        Text2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //OffBelieveTextOnDontText();
    }

    public void OffBelieveTextOnDontText()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
}
