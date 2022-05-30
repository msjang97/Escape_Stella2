using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2Manager : MonoBehaviour
{
    public GameObject GameManagerObj;

    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Camera1;

    public GameObject PlayerObj;

    private bool StartMoveMonster = false;

    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        StartMoveMonster = GameManagerObj.GetComponent<Stage2_PlayerDialog>().StartMonster;
    }

    // Update is called once per frame
    void Update()
    
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            SceneManager.LoadScene("Stage2");
            Time.timeScale = 1;
        }

        StartMoveMonster = GameManagerObj.GetComponent<Stage2_PlayerDialog>().StartMonster;

        if (StartMoveMonster)
        {
            Canvas1.SetActive(false);
            Canvas2.SetActive(true);
            Camera1.SetActive(true);
        }

        if (PlayerObj.transform.position.y <= -40.0f)
        {
            SceneManager.LoadScene("Stage2");
            Time.timeScale = 1;
        }
    }
    
    
}
