using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class RotationSlider : MonoBehaviour
{

    //Slider for RotationSpeed:
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
        string sliderMessage = "Rotation Speed: " + sliderUI.value;
        textSliderValue.text = sliderMessage;
        PlayerPrefs.SetInt("RotateSpeed", (int)sliderUI.value);
        Debug.Log("Rotate Speed Set to: " + sliderUI.value);
    }
}
