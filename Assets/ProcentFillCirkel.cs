﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class ProcentFillCirkel : MonoBehaviour
{
    // Start is called before the first frame update
    //For Cirkel
    public Image cirkel;
    public InputTransfer inputTransfer;
    //public float moneyUsed = 1;

    //For Text
    public GameObject amountOfMoneyLeft; //The text 
    public MoneyUsed moneyUsed;
    public float moneyLeft;

    public GameObject moneyLeftText;

    // Update is called once per frame
    public void Update()
    {
        FillCirkel();
        MoneyLeftText();
       // moneyLeftText.GetComponent<Text>().text = moneyLeft + "$";
    }
    public void FillCirkel()
    {

        cirkel.fillAmount = ((inputTransfer.amountOfMoney - moneyUsed.moneyUsedNow) / inputTransfer.amountOfMoney);
    }
    public void MoneyLeftText()
    {
        moneyLeft = inputTransfer.amountOfMoney - moneyUsed.moneyUsedNow;
        amountOfMoneyLeft.GetComponent<Text>().text = "Money left: " + moneyLeft;
    }
}
