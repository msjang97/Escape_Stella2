using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    public GameObject gameSettingUI;
    public bool SettingScreen;
    // Start is called before the first frame update
    void Start()
    {
        SettingScreen = false;
        gameSettingUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OngameSetting() // ����â on
    {
        if (SettingScreen == false) { 
            gameSettingUI.SetActive(true);
            SettingScreen = true;
        }
        return;
    }

    public void OffgameSetting() //����â off
    {
        if(SettingScreen == true)
        {
            gameSettingUI.SetActive(false);
            SettingScreen = false;
        }
        return;      
    }

}
