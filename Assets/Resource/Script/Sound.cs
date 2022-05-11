using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    public GameObject BackgroundMusic;



    void Awake()
    {      
 
      

    }

    // Start is called before the first frame update
    public void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(BackgroundMusic);
        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            Destroy(gameObject);
        }
    }
}
