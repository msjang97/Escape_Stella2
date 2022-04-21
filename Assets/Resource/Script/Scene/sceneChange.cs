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
        SceneManager.LoadScene("Prologue"); // Tutorial scene �̵�.
    }

    public void GameOverButton()
    {
        Application.Quit(); // ��������

    }




    public void OnCollisionEnter2D(Collision2D other) // endpoint ������Ʈ�� �����ϸ� �� �̸��� �ε��� ��ü�� ���� �������� ����.
    {
        if (SceneManager.GetActiveScene().name == "Tutorial" && other.gameObject.name == "Player")
        {
            Debug.Log("�����");
            SceneManager.LoadScene("Stage1");
        }

        else if (SceneManager.GetActiveScene().name == "Stage1" && other.gameObject.name == "Player")
        {
            Debug.Log("stage1 �Ѿ�� ���� �����");
            SceneManager.LoadScene("Stage2");
        }

        else if (SceneManager.GetActiveScene().name == "Level" && other.gameObject.name == "Easy")
        {
            Debug.Log("�����");
            SceneManager.LoadScene("EasyStage1");
        }

        else if (SceneManager.GetActiveScene().name == "Level" && other.gameObject.name == "Hard")
        {
            Debug.Log("�����");
            SceneManager.LoadScene("HardStage1");
        }


        else if (SceneManager.GetActiveScene().name == "HardStage1" && other.gameObject.name == "Player")
        {
            Debug.Log("�����");
            SceneManager.LoadScene("HardStage2");
        }

        else if (SceneManager.GetActiveScene().name == "HardStage2" && other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("HardStage3");
        }
    }
}
