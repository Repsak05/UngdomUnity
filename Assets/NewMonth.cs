using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewMonth : MonoBehaviour
{
    //
    public InputTransfer inputTransfer;
    public MoneyUsed moneyUsed;
    public DisplayChallenges displayChallenges;
    public Transaction transaction;
    public float totalIncome = 0;
    public float totalIncomeCopy = 0;
    List<string> moneySpentList = new List<string>();


    //
    string theTextDay;
    string theTextMonth;
    string theTextYear;
    public GameObject dayText;
    public GameObject monthText;
    public GameObject yearText;

    public int totalAmountOfDays;
    public int day;
    public string month;
    int year = 2022;
    public string[] allMonths = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
    public int[] daysPrMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    public int extraMonth = 11;
    float moneyUsedThisMonth = 0f;
    public int daysBeforeResetCreateChallenge = 0;

    
    void Start()
    {
        month = allMonths[extraMonth];
        totalIncomeCopy = totalIncome;
    }

    public void NewDay()
    {
        if(moneyUsed.moneyUsedNow > 0)
        {
            totalAmountOfDays++;
            day++;
            daysBeforeResetCreateChallenge++;
            DailyMoneySpent();
            //transaction.AddMoneyUsedToTotalValue();
            transaction.RecentMoneyUsed();
            if (month == allMonths[11] && day > daysPrMonth[11])
            {
                print("NEW YEAR");
                day = 1;
                extraMonth = 0;
                month = allMonths[extraMonth];
                year++;

            }
            if (day > daysPrMonth[extraMonth])
            {
                totalIncomeCopy = 0;
                moneyUsedThisMonth = 0;

                month = allMonths[extraMonth + 1];
                extraMonth += 1;
                day = 1;
            }

            theTextDay = "Day: " + day;
            dayText.GetComponent<Text>().text = theTextDay;

            theTextMonth = "Month: " + month;
            monthText.GetComponent<Text>().text = theTextMonth;

            theTextYear = "Year: " + year;
            yearText.GetComponent<Text>().text = theTextYear;

        }
        else
        {
            print("Select money used today");
        }
        
    }
    void DailyMoneySpent()
    {
        totalIncome += moneyUsed.moneyUsedNow;
        totalIncomeCopy += moneyUsed.moneyUsedNow;
        moneyUsedThisMonth += moneyUsed.moneyUsedNow;
        moneySpentList.Add(moneyUsed.moneyUsedNow.ToString("0"));
        print("Total amount used: " + totalIncome);
    }
}

