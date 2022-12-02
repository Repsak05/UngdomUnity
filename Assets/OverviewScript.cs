using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OverviewScript : MonoBehaviour
{
    public NewMonth newMonth;
    
    public GameObject januaryStatsText;
    public GameObject februaryStatsText;
    public GameObject marchStatsText;
    public GameObject aprilStatsText;
    public GameObject mayStatsText;
    public GameObject juneStatsText;
    public GameObject julyStatsText;
    public GameObject augustStatsText;
    public GameObject septemberStatsText;
    public GameObject octoberStatsText;
    public GameObject novemberStatsText; //text
    public GameObject decemberStatsText;

    float januaryStats;
    float februaryStats;
    float marchStats;
    float aprilStats;
    float mayStats;
    float juneStats;
    float julyStats;
    float augustStats;
    float septemberStats;
    float octoberStats;
    float novemberStats;
    float decemberStats;
    
    void Update()
    {
        ItsJanuary();
        ItsFebruary();
        ItsMarch();
        ItsApril();
        ItsMay();
        ItsJune();
        ItsJuly();
        ItsAugust();
        ItsSeptember();
        ItsOctober();
        ItsNovember();
        ItsDecember();
    }
    //Its_Month;

    void ItsJanuary()
    {
        if (newMonth.month == newMonth.allMonths[1-1])
        {
            januaryStats = newMonth.totalIncomeCopy;
            januaryStatsText.GetComponent<Text>().text = "Jan. " + januaryStats + "$";
        }
    }
    void ItsFebruary()
    {
        if (newMonth.month == newMonth.allMonths[2 - 1])
        {
            februaryStats = newMonth.totalIncomeCopy;
            februaryStatsText.GetComponent<Text>().text = "Feb. " + februaryStats + "$";
        }
    }
    void ItsMarch()
    {
        if (newMonth.month == newMonth.allMonths[3 - 1])
        {
            marchStats = newMonth.totalIncomeCopy;
            marchStatsText.GetComponent<Text>().text = "Mar. " + marchStats + "$";
        }
    }
    void ItsApril()
    {
        if (newMonth.month == newMonth.allMonths[4 - 1])
        {
            aprilStats = newMonth.totalIncomeCopy;
            aprilStatsText.GetComponent<Text>().text = "Apr. " + aprilStats + "$";
        }
    }
    void ItsMay()
    {
        if (newMonth.month == newMonth.allMonths[5 - 1])
        {
            mayStats = newMonth.totalIncomeCopy;
            mayStatsText.GetComponent<Text>().text = "May. " + mayStats + "$";
        }
    }
    void ItsJune()
    {
        if (newMonth.month == newMonth.allMonths[6 - 1])
        {
            juneStats = newMonth.totalIncomeCopy;
            juneStatsText.GetComponent<Text>().text = "Jun. " + juneStats + "$";
        }
    }
    void ItsJuly()
    {
        if (newMonth.month == newMonth.allMonths[7 - 1])
        {
            julyStats = newMonth.totalIncomeCopy;
            julyStatsText.GetComponent<Text>().text = "Jul. " + julyStats + "$";
        }
    }
    void ItsAugust()
    {
        if (newMonth.month == newMonth.allMonths[8 - 1])
        {
            augustStats = newMonth.totalIncomeCopy;
            augustStatsText.GetComponent<Text>().text = "Aug. " + augustStats + "$";
        }
    }
    void ItsSeptember()
    {
        if (newMonth.month == newMonth.allMonths[9 - 1])
        {
            septemberStats = newMonth.totalIncomeCopy;
            septemberStatsText.GetComponent<Text>().text = "Sep. " + septemberStats + "$";
        }
    }
    void ItsOctober()
    {
        if (newMonth.month == newMonth.allMonths[10 - 1])
        {
            octoberStats = newMonth.totalIncomeCopy;
            octoberStatsText.GetComponent<Text>().text = "Oct. " + octoberStats + "$";
        }
    }
    void ItsNovember()
    {
        if (newMonth.month == newMonth.allMonths[11-1])
        {
            novemberStats = newMonth.totalIncomeCopy;
            novemberStatsText.GetComponent<Text>().text = "Nov. " + novemberStats + "$";
        }
    }
    void ItsDecember()
    {
        if (newMonth.month == newMonth.allMonths[12 - 1])
        {
            decemberStats = newMonth.totalIncomeCopy;
            decemberStatsText.GetComponent<Text>().text = "Dec. " + decemberStats + "$";
        }
    }
}
