using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Transaction : MonoBehaviour
{
    public MoneyUsed moneyUsed;
    public InputTransfer inputTransfer;
    public NewMonth newMonth;
    // Start is called before the first frame update
    string[] categories = { "Transport", "Household", "Food", "Lesuer", "Travel", "Other" };
    string[] transport = { "Fuel", "Public transport", "Parking" };
    string[] household = { "pharmacy", "Medic", "Childcare", "Pets", "Healthcare", "TV/Streaming", "Education", "Membership", "housekeeping and gardening" };
    string[] food = { "Supermarked", "Fastfood/Takeaway", "Restaurant", "Bars", "Alcohol", "Candy" };
    string[] lesuer = { "Clothing and accessories", "Eletronic and copter", "Movies, music and books", "Hobby and sports equipment", "Cinama", "Hairdresser", "Sport", "Games and toys", "gambling and betting", "Gifts and charity" };
    string[] travel = { "Flights and hotel", "Car rental", "Vacation and camping", "Vacation activities" };
    string[] deptAndInterest = { "Student loan", "Consumer loan", "Private loan", "Interest" };
    string[] other = { "Unknown", "Bank fees", "Late fees", "Finds", "Unpaid taxes", "Stocks", "Public fee" };
    public int[] transportMoney = { 0, 0, 0, 0, 0 };
    int[] householdMoney;
    int[] foodMoney;
    int[] lesuerMoney;
    int[] travelMoney;
    int[] deptAndInterestMoney;
    int[] otherMoney;

    public float[] mostRecentMoneyUsed = { 0, 0, 0, 0, 0 };

    public GameObject totalMoneyUsedText;

    float usedMoneyValue;
    int timesRunThru = 0;
    public GameObject textOne;
    public GameObject textTwo;
    public GameObject textThree;
    public GameObject textFour;
    public GameObject textFive;
    public void RecentMoneyUsed()
    {
        //Maybe make sure day count rises aswell
        timesRunThru++;
        usedMoneyValue = moneyUsed.moneyUsedNow;
        mostRecentMoneyUsed[4] = mostRecentMoneyUsed[3];
        mostRecentMoneyUsed[3] = mostRecentMoneyUsed[2];
        mostRecentMoneyUsed[2] = mostRecentMoneyUsed[1];
        mostRecentMoneyUsed[1] = mostRecentMoneyUsed[0];
        mostRecentMoneyUsed[0] = usedMoneyValue;

        if (timesRunThru >= 1)
        {
            textOne.GetComponent<Text>().text = mostRecentMoneyUsed[0] + "$";
        }
        if (timesRunThru >= 2)
        {
            textTwo.GetComponent<Text>().text = mostRecentMoneyUsed[1] + "$";
        }
        if (timesRunThru >= 3)
        {
            textThree.GetComponent<Text>().text = mostRecentMoneyUsed[2] + "$";
        }
        if (timesRunThru >= 4)
        {
            textFour.GetComponent<Text>().text = mostRecentMoneyUsed[3] + "$";
        }
        if (timesRunThru >= 5)
        {
            textFive.GetComponent<Text>().text = mostRecentMoneyUsed[4] + "$";
        }
    }

    //Transport
    public GameObject transportText;
    public GameObject fuelText;
    public GameObject publicTransportText;
    public GameObject parkingText;
    public int fuelMoneyUsed;
    int publicTransportMoneyUsed = 0;
    int parkingMoneyUsed = 0;
    //Household
    string pharmacy;
    string medic;
    string childcare;
    string pets;
    string healthcare;
    string tvAndStreaming;
    string education;
    string memembership;
    string houseKeepingAndGardening;



    void Start()
    {

        UpdateTransport();
        print(categories.Length);
        print(transport[0]);
        print(transport[1]);
        print(transport[2]);
    }

    void UpdateTransport()
    {
        fuelText.GetComponent<Text>().text = transport[1] + ".";
    }

    // Update is called once per frame
    void Update()
    {

        totalMoneyUsedText.GetComponent<Text>().text = (inputTransfer.amountOfMoney - newMonth.totalIncome) + "$";

    }
}
