using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friends : MonoBehaviour
{
    //name#ID
    public GameObject nameIDText;
    public GameObject inputField;
    public string yourName;

    List<string> gamerTag = new List<string>();

   
    //Add frinds
    int indexOfName;
    public GameObject addNameText;
    public GameObject addNameInputField;
    string addName;

    List<string> yourFriends = new List<string>();

    void Start()
    {
        gamerTag.Add("Felix");
        gamerTag.Add("Gustav");
        gamerTag.Add("Kristian");
        gamerTag.Add("Nordin");

        yourFriends.Add(gamerTag[0]);
        LeaderBoard();


    }

    public void Update()
    {
        

        yourFriends.Add(gamerTag[0]);
        yourFriends.Add(gamerTag[1]);
        yourFriends.Add(gamerTag[2]);
        yourFriends.Add(gamerTag[3]);
        


        

    }

    public void AddNameToList()
    {
        yourName = inputField.GetComponent<Text>().text;

        if (gamerTag.Contains(yourName))
        {
            nameIDText.GetComponent<Text>().text = "Name alredy taken";
        }
        else
        {
            gamerTag.Add(yourName);
            nameIDText.GetComponent<Text>().text = "ID:" + yourName;
        }
    }

    //Add friends
    public void AddFriend()
    {
        addName = addNameInputField.GetComponent<Text>().text;

        if (gamerTag.Contains(addName))
        {
            indexOfName = gamerTag.IndexOf(addName);

            yourFriends.Add(gamerTag[indexOfName]);
            addNameText.GetComponent<Text>().text = addName + " is now added";
        }
        else
        {
            addNameText.GetComponent<Text>().text = addName+" Could not be found";
        }
    }

    //
    //
    //
    //
    //Leaderboards
    //
    //
    //
    //Friends points is Hard coded 
    //
    //
    //

    int nordinPoints = 5;
    public Image nordinPicture;

    int felixPoints = 21;
    public Image felixPicture;

    int gustavPoints = 4;
    public Image gustavPicture;

    int kristianPoints = 6;
    public Image kristianPicture;

    int yourPoints = 101;
    public Image yourPicture;

    int nordinPlaceOnLeaderboard;
    int felixPlaceOnLeaderboard;
    int gustavPlaceOnLeaderboard;
    int kristianPlaceOnLeaderboard;
    int yourPlaceOnLeaderboard;

    int one = 0;

    List<int> friendsOnLeaderboard = new List<int>();
    List<int> placeOnLeaderboard = new List<int>();
    Image[] picInRow = new Image[6];

    //List<Image> picInRow = new List<Image>();
    //public Image[] picInRow = { nordinPicture, felixPicture };

    public void LeaderBoard()
    {
        friendsOnLeaderboard.Add(nordinPoints);
        friendsOnLeaderboard.Add(felixPoints);
        friendsOnLeaderboard.Add(kristianPoints);
        friendsOnLeaderboard.Add(gustavPoints);
        friendsOnLeaderboard.Add(yourPoints);

        friendsOnLeaderboard.Sort();
        
        foreach (int value in friendsOnLeaderboard)
        {
            print(friendsOnLeaderboard[one]);
            one++;
        }

        nordinPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(nordinPoints);
        felixPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(felixPoints);
        gustavPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(gustavPoints);
        kristianPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(kristianPoints);
        yourPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(yourPoints);

        

        /*
        placeOnLeaderboard.Add(nordinPlaceOnLeaderboard);
        placeOnLeaderboard.Add(felixPlaceOnLeaderboard);
        placeOnLeaderboard.Add(gustavPlaceOnLeaderboard);
        placeOnLeaderboard.Add(kristianPlaceOnLeaderboard);
        placeOnLeaderboard.Add(yourPlaceOnLeaderboard);

        placeOnLeaderboard.Sort();
        */

        picInRow[nordinPlaceOnLeaderboard] = nordinPicture;
        picInRow[gustavPlaceOnLeaderboard] = gustavPicture;
        picInRow[felixPlaceOnLeaderboard] = felixPicture;
        picInRow[kristianPlaceOnLeaderboard] = kristianPicture;
        picInRow[yourPlaceOnLeaderboard] = yourPicture;

        for(int i = 0; i<friendsOnLeaderboard.Count; i++)
        {
            RectTransform picture = picInRow[i].GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(i*-150+30, -50);
        }

        /*
        RectTransform pic0 = picInRow[0].GetComponent<RectTransform>();
        pic0.anchoredPosition = new Vector2(-100, -150);

        RectTransform pic1 = picInRow[1].GetComponent<RectTransform>();
        pic1.anchoredPosition = new Vector2(0, -150);

        RectTransform pic2 = picInRow[2].GetComponent<RectTransform>();
        pic2.anchoredPosition = new Vector2(0, -150);
        */

        //transform.position(20, 10); 



        //Use x.y position to locate where the pics need to bee
        // :: Location1 = placeOnLeaderboad[0]
        // if(placeOnLeaderboad[0] == nordin, make him first else, try another);
    }
    //Show friends
    //indexOfName, sort after points, place in leaderboard
}
