using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplayChallenges : MonoBehaviour
{
    public CreateChallenge createChallange;
    public SliderScript sliderScriptTimeToFinnish;
    public SliderScript sliderScriptSpendLessThan;
    public NewMonth newMonth;
    public MoneyUsed moneyUsed;
    

    public GameObject daysLeftText;
    public float daysLeft;
    public GameObject moneyLeftText; //sliderScriptSpendLessThan.slider.maxValue - money used since challenge started (variation af ___totalIncomeCopy)
    public float moneyleft;

    public Slider slider;
    public float value;

    void Start()
    {
        
    }

    void Update()
    {
        if(createChallange.timesStartButtonHasBeenClicked > 0)
        {
            ShowChallenges();
        }
        UpdateSlider();
        ShowC2();


        //SetActive (the elements that should/shouldn't be there while active/done)
        if (daysLeft < 0)
        {
            daysLeftText.SetActive(false);
            moneyLeftText.SetActive(false);
            slider.gameObject.SetActive(false);
        }
        else
        {
            daysLeftText.SetActive(true);
            moneyLeftText.SetActive(true);
            slider.gameObject.SetActive(true);
        }
    }
 
    public void ShowChallenges()
    {
        daysLeft = sliderScriptTimeToFinnish.value - (newMonth.totalAmountOfDays - createChallange.startDay);
        daysLeftText.GetComponent<Text>().text = daysLeft + " Days Left";

        moneyleft = sliderScriptSpendLessThan.value - newMonth.totalIncome;
        moneyLeftText.GetComponent<Text>().text = moneyleft + "$";
    }

    public void UpdateSlider()
    {
        slider.maxValue = sliderScriptSpendLessThan.value;
        slider.value = moneyleft;
    }

    // C2
    //
    //
    //
    //
    //
    public GameObject daysLeftC2Text;
    float daysLeftC2;

    public GameObject moneyLeftC2Text;
    float moneyLeftC2;

    public void ShowC2()
    {
        daysLeftC2 = newMonth.daysPrMonth[newMonth.extraMonth] - newMonth.day;
        daysLeftC2Text.GetComponent<Text>().text = daysLeftC2 + "";

        moneyLeftC2Text.GetComponent<Text>().text = "Change in DisplayChallenges";
    }
}
