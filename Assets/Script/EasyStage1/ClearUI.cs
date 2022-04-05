using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearUI : MonoBehaviour
{
    public GameObject Player;
    public GameObject StartUI;
    
    public GameObject Camera;
    public string SceneName;

    // Start is called before the first frame update
    void Awake()
    {
        Player.SetActive(false);
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Player.SetActive(true);
        
    }

    public void CloseStartUI()
    {
        StartUI.SetActive(false);
        Cursor.visible = false;
        Camera.SetActive(false);
        Player.SetActive(true);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            {           
                SceneManager.LoadScene("Title");
            }
        }
    }
}
