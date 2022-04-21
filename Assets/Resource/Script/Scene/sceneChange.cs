using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);     
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        SceneManager.LoadScene("Prologue"); // Tutorial scene 이동.
    }

    public void GameOverButton()
    {
        Application.Quit(); // 게임종료

    }




    public void OnCollisionEnter2D(Collision2D other) // endpoint 오브젝트에 도달하면 씬 이름과 부딪힌 물체에 따라 스테이지 변경.
    {
        if (SceneManager.GetActiveScene().name == "Tutorial" && other.gameObject.name == "Player")
        {
            Debug.Log("닿았음");
            SceneManager.LoadScene("Stage1");
        }

        else if (SceneManager.GetActiveScene().name == "Stage1" && other.gameObject.name == "Player")
        {
            Debug.Log("stage1 넘어가는 문에 닿았음");
            SceneManager.LoadScene("Stage2");
        }

        else if (SceneManager.GetActiveScene().name == "Level" && other.gameObject.name == "Easy")
        {
            Debug.Log("닿았음");
            SceneManager.LoadScene("EasyStage1");
        }

        else if (SceneManager.GetActiveScene().name == "Level" && other.gameObject.name == "Hard")
        {
            Debug.Log("닿았음");
            SceneManager.LoadScene("HardStage1");
        }


        else if (SceneManager.GetActiveScene().name == "HardStage1" && other.gameObject.name == "Player")
        {
            Debug.Log("닿았음");
            SceneManager.LoadScene("HardStage2");
        }

        else if (SceneManager.GetActiveScene().name == "HardStage2" && other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("HardStage3");
        }
    }
}
