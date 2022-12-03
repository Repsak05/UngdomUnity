using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateChallenge : MonoBehaviour
{
    public GameObject createChallengeText;

    //Display current active challenges

    //Create challenges
    //1. Spend less than ___ a week/month
    //2. Spend less on ___.

    //Give points/gold/diamounds.


    //Challenge 1.
    public InputTransfer inputTransfer; //Money got (inputTransfer.amountOfMoney)
    public MoneyUsed moneyUsed; //moneyUsed (moneyUsed.moneyUsedNow)
    public NewMonth newMonth; //Date, month, year. (  newMonth.day     newMonth.month     newMonth.year  )
    public DisplayChallenges displayChallenges; //displayChallenges.ShowChallenges()

    public SliderScript sliderScriptSpendLessThan;
    public SliderScript sliderScriptTimeToFinnish;
    public Friends friends;

    public GameObject receiveTextGold;
    float receieveAmountOfGold;
    int startNewChallengeOne = 0;

    public GameObject receiveTextDiamounds;
    float receiveAmountOfDiamounds;

    //Start the challenge
    public int startDay;
    public int timesStartButtonHasBeenClicked = 0;


    void Update()
    {
        print("startNEWCHALLWFNW = AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA: " + startNewChallengeOne);
        //print("Spend less than: " + sliderScriptSpendLessThan.value);
        //print("Time To Finnish: " + sliderScriptTimeToFinnish.value);
        CalculateGold();
        ReceieveTheGoldIf();
        print("Receieve gold: " + receieveAmountOfGold);

        receiveTextGold.GetComponent<Text>().text = "You will receieve: " +receieveAmountOfGold.ToString("0") + " gold";


        //.....................Challenge 2.................
        TextAssign();
        CaculateCirkelSlider();
    }

    void CalculateGold()
    {
        float value = sliderScriptSpendLessThan.slider.maxValue + 100;
        receieveAmountOfGold = (value-sliderScriptSpendLessThan.value) / 100 * sliderScriptTimeToFinnish.value;
        
    }

    public void StartButtonHasBeenClicked()
    {
        //call this funtion when start button is clicked
        if (timesStartButtonHasBeenClicked == 0)
        {
            print("Challenge accepted");
            startDay = newMonth.totalAmountOfDays;
            startNewChallengeOne = 0;

        }
        
        
        timesStartButtonHasBeenClicked += 1;

    }

    void ReceieveTheGoldIf()
    {
        //If the you succed the challenge give points
        //Check day before and after (when challenge start, and when the amount of days has gone...) (first time, check when click "start challenge" button)

        if((newMonth.totalAmountOfDays - startDay) >= sliderScriptTimeToFinnish.value && newMonth.totalIncome <= sliderScriptSpendLessThan.value) // && challenge completed
        {
            
            //Check if you've lost of won the challenge
            //Then give rewars if succeded
            print("You've won the challenge");
            if(startNewChallengeOne < 1 )
            {
                
                print("Receieve amount of gold SSSSSSSSSSSSSSSSSSSSSSSSSSS: " + receieveAmountOfGold);
                print("YOU'VE RECEIVED YOUR GOLD" + (int)Math.Round((double)receieveAmountOfGold, 0));
                startNewChallengeOne++;
                friends.yourPointsAdd += (int)Math.Round((double)receieveAmountOfGold, 0);
                print("YOUR POINTS KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK: " + friends.yourPointsAdd);
                friends.AddPoints();
            }
            
        }
    }
    void CalculateDiamounds()
    {

    }
    /*
    Transport
        fuel
        public
        parking

    Household
        Faremsy
        medic
        Childcare
        Pets
        Healthcare
        Tv-streaming
        Education
        Membership
        Housekeepeing and gardening   

    Food
        Supermarked
        Fastfood (takeaway)
        resturant
        bars
        alcohol and tobac

    Leisuer
        clothing and exerorises
        eletronic and computer
        Movies, music and books
        Hoppy and sport exuppment
        Cinama
        Internanement
        Hairdresser
        Sport
        games and toys
        gambling and betting
        Gifts and cherituy


    Travel  
        Flights and hotel
        Car rental
        vacationhome and camping
        vacation activities

    Other
        Unknown
        Bank-fees
        Late-fees
        finds
        Unpaid taxes
        stocks
        Public fee
        
    Dept and interest
        Studenloan
        consumer loan   
        Private loan (friends and family)
        Interest

    Income
        salary
        unenploment beenfits
        student grant
        child benefit
        holiday pay
        interest income
        Yeld and returns
        

        

        
        
        
       

        
        
    Meal
    TV and streaming
    Adventures
    Rent
    Utillities
    
    */

    //.......................Challenge two....................................

    int spendLessThan;
    string titleOne = "No more fries";
    string descriptiveSentence = "Use less money on fast food";
    public GameObject titleOneText;
    public GameObject descriptiveSentenceText;
    public GameObject daysLeftText;
    public Image cirkel;
    float fillCirkelAmount = 0f;

    void CaculateCirkelSlider()
    {
        //cirkel.fillAmount = (inputTransfer.amountOfMoney - moneyUsed.moneyUsedNow) / inputTransfer.amountOfMoney; // virekr ik
        fillCirkelAmount = ((inputTransfer.amountOfMoney - moneyUsed.moneyUsedNow) / inputTransfer.amountOfMoney);
        cirkel.fillAmount = fillCirkelAmount;
        print("Fill amount: " + fillCirkelAmount);
    }
    void TextAssign()
    {
        titleOneText.GetComponent<Text>().text = titleOne;
        descriptiveSentenceText.GetComponent<Text>().text = descriptiveSentence;
        
        //have to be in update function
        daysLeftText.GetComponent<Text>().text = newMonth.day + " / " + newMonth.daysPrMonth[newMonth.extraMonth];
    }

    void ResetChallengeTwo()
    {
        if (newMonth.daysBeforeResetCreateChallenge > newMonth.daysPrMonth[newMonth.extraMonth])
        {
            //reset money used and progress of challenge (start same but new)
        }
    }

}
