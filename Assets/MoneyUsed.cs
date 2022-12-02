using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUsed : MonoBehaviour
{
    public float moneyUsedNow;
    public GameObject inputField;
    public GameObject textDisplay;

    public NewMonth newMonth;
    float dayCount = 0.1f;

    public void AmountOfMoneyUsed()
    {
        moneyUsedNow = float.Parse(inputField.GetComponent<Text>().text);
        textDisplay.GetComponent<Text>().text = moneyUsedNow + "$";
    }
    public void UpdateMoneyText()
    {
        textDisplay.GetComponent<Text>().text = moneyUsedNow + "$";
        print("Update money Text");
    }

    void Update()
    {
        if(newMonth.totalAmountOfDays > dayCount)
        {
            dayCount += 1;
            moneyUsedNow = 0;
            UpdateMoneyText();
        }
    }
}
