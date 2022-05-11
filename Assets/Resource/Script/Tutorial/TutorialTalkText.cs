
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTalkText : MonoBehaviour
{
    public GameObject PlayerObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position =new Vector3(PlayerObj.transform.position.x, PlayerObj.transform.position.y + 8, PlayerObj.transform.position.z);

    }


}
