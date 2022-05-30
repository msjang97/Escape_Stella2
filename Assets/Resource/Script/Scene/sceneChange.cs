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
            SceneManager.LoadScene("Stage1");
        }

        if (SceneManager.GetActiveScene().name == "Stage1" && other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(4);
        }

        if (SceneManager.GetActiveScene().name == "Stage3to2" && other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Stage2");
        }

        if (SceneManager.GetActiveScene().name == "Stage2" && other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Stage2To1");
        }

        if (SceneManager.GetActiveScene().name == "Stage2To1" && other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("LastStage");
        }

        if (SceneManager.GetActiveScene().name == "LastStage" && other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
