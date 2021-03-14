using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PinSpeed : MonoBehaviour
{

    //Slider for PinSpeed:
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
        string sliderMessage = "Pin Speed: " + sliderUI.value;
        textSliderValue.text = sliderMessage;
        PlayerPrefs.SetInt("PinSpeed", (int)sliderUI.value);
        Debug.Log("Pin Speed Set to: " + sliderUI.value);
    }
}
