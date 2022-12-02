using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTransfer : MonoBehaviour
{
    public float amountOfMoney;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreMoney()
    {
        amountOfMoney = float.Parse(inputField.GetComponent<Text>().text);
        textDisplay.GetComponent<Text>().text = amountOfMoney + "$";
    }

}
