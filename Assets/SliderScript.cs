using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;
    public GameObject sliderText;
    public float value;
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            value = v;
            sliderText.GetComponent<Text>().text = v.ToString("0");
        });
    }

}
