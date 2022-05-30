using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;



public class Sound : MonoBehaviour
{
    public GameObject BackgroundMusic;

    public AudioMixer AudioMixer; //오디오믹서
    public Slider AudioSlider;

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
        Debug.Log(AudioSlider.value);
        DontDestroyOnLoad(BackgroundMusic);
        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            Destroy(gameObject);
        }
    }

    public void SetSoundVal(float SliderValue)
    {
        float Soundvaule = 0;
        Soundvaule = SliderValue;
        if (Soundvaule == -40)
        {
            AudioMixer.SetFloat("Title", 0);
        }
        else
        AudioMixer.SetFloat("Title", Mathf.Log10(Soundvaule) * 20 +10);
    }
}
