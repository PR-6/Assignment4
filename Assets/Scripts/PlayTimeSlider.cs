using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayTimeSlider : MonoBehaviour
{
    //Slider for PlayTime:
    public Slider sliderUI;
    private Text textSliderValue;

    // Start is called before the first frame update
    void Start()
    {
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    //Slider Speed logic:
    public void ShowSliderValue()
    {
        string sliderMessage = "PlayTime: " + sliderUI.value + " Min";
        textSliderValue.text = sliderMessage;
        PlayerPrefs.SetInt("PlayTime", (int)sliderUI.value);
        Debug.Log("PlayTime Set to: " + sliderUI.value);
    }

    public int getPlayTimeValue()
    {
        return PlayerPrefs.GetInt("PlayTime", 1);
    }
}
