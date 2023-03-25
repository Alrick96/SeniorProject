using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class BrightnessControls : MonoBehaviour
{
    [SerializeField] private Slider m_Slider;
    [SerializeField] private PostProcessProfile Brightness;
    [SerializeField] private PostProcessLayer TheLayer;
    public userLoading userLoading1;
    private int Act =0;

    AutoExposure exposure;
    // Start is called before the first frame update
    void Start()
    {
        Brightness.TryGetSettings(out exposure);
        ChangeBrightness(m_Slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        Act = PlayerPrefs.GetInt("brightnessSwitch");
        Debug.Log("the saved  data"+PlayerPrefs.GetInt("brightnessSwitch"));
        Debug.Log("this is the brightness value" + Act);
        if (Act != 0)
        {
            login();
            Debug.Log("it's loging in");
        }
    }

    private void login()
    {
        float loginExposer = PlayerPrefs.GetFloat("Brightness");
        Debug.Log(" Brightness data "+loginExposer);
        ChangeBrightness(loginExposer);
        m_Slider.value = loginExposer;
        PlayerPrefs.SetInt("brightnessSwitch",0);
    }

    public void changeData()
    {
        float data = m_Slider.value;
        PlayerPrefs.SetFloat("Brightness", data);
        userLoading1.WriteString();
    }
    public void ChangeBrightness(float theInput)
    {

        if (theInput != 0)
        {
            Debug.Log("it is not 0 so should change");
            exposure.keyValue.value = theInput;
        }
        else
        {
            Debug.Log("it's zero so it's set to .2f");
            exposure.keyValue.value = .2f;
        }
    }
}
