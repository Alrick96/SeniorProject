using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private AudioSource m_AudioSource;
    [SerializeField] private Slider TheSlider;
    [SerializeField] private float VolumeLevel = 1f;
    int Act;
    public userLoading userLoading1;
    void Start()
        
    {
        m_AudioSource.Play();
        // if there is a volume in playerPref set it to that
        VolumeLevel = PlayerPrefs.GetFloat("volume");

        //well set the audio and the slider to the volume
        m_AudioSource.volume= VolumeLevel;
        TheSlider.value= VolumeLevel;
        
    }
    void Update()
    {

        Act = PlayerPrefs.GetInt("soundIn");
        if (Act != 0)
        {
            login();
        }
        
    }

    void login()
    {
        VolumeLevel = PlayerPrefs.GetFloat("volume");

        //well set the audio and the slider to the volume
        m_AudioSource.volume= VolumeLevel;
        TheSlider.value= VolumeLevel;
        PlayerPrefs.SetInt("soundIn", 0);
    }
    public void change()
    {
        m_AudioSource.volume = VolumeLevel;
        //PlayerPrefs will create or update volume with VolumeLevel
        PlayerPrefs.SetFloat("volume", VolumeLevel);
        userLoading1.WriteString();
    }

    public void SetVolume(float volume)
    {
        VolumeLevel= volume;
    }
}
