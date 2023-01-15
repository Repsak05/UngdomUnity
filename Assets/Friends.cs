using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

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
        UpdateLeaderBoard();
        yourFriends.Add(gamerTag[0]);
        yourFriends.Add(gamerTag[1]);
        yourFriends.Add(gamerTag[2]);
        yourFriends.Add(gamerTag[3]);

        diamoundsText.GetComponent<Text>().text = yourPoints + "";
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

    int nordinPoints = 55;
    public Image nordinPicture;

    int felixPoints = 21;
    public Image felixPicture;

    int gustavPoints = 9;
    public Image gustavPicture;

    int kristianPoints = 2;
    public Image kristianPicture;

    public int yourPoints = 0;
    public int yourPointsAdd = 0;
    public Image yourPicture;

    int nordinPlaceOnLeaderboard;
    int felixPlaceOnLeaderboard;
    int gustavPlaceOnLeaderboard;
    int kristianPlaceOnLeaderboard;
    int yourPlaceOnLeaderboard;

    //TOP 3 BOX
    public Image box1;
    public Image box2;
    public Image box3;

    //POINT TO TEXT (TOP 5)
    public GameObject firstPlacePointText;
    public GameObject secoundPlacePointText;
    public GameObject thirdPlacePointText;
    public GameObject forthPlacePointText;
    public GameObject fifthPlacePointText;
    //POINT TO TEXT DONE

    //PERSON TEXT (TOP 5)
    public GameObject firstPlaceNameText;
    public GameObject secoundPlaceNameText;
    public GameObject thirdPlaceNameText;
    public GameObject forthPlaceNameText;
    public GameObject fifthPlaceNameText;
    //PERSON TEXT DONE

    public GameObject diamoundsText;

    int one = 0;

    List<int> friendsOnLeaderboard = new List<int>();
    List<int> placeOnLeaderboard = new List<int>();
    Image[] picInRow = new Image[6];
    String[] namesInRow = new string[6];

    //List<Image> picInRow = new List<Image>();
    //public Image[] picInRow = { nordinPicture, felixPicture };

    public void LeaderBoard()
    {
        friendsOnLeaderboard.Add(nordinPoints);
        friendsOnLeaderboard.Add(felixPoints);
        friendsOnLeaderboard.Add(kristianPoints);
        friendsOnLeaderboard.Add(gustavPoints);
        friendsOnLeaderboard.Add(yourPoints);
    }
    public void UpdateLeaderBoard()
    {
        friendsOnLeaderboard.Sort();

        //POINT TO TEXT (TOP 5)
        firstPlacePointText.GetComponent<Text>().text = friendsOnLeaderboard[4 - 0] + "";
        secoundPlacePointText.GetComponent<Text>().text = friendsOnLeaderboard[4 - 1] + "";
        thirdPlacePointText.GetComponent<Text>().text = friendsOnLeaderboard[4 - 2] + "";
        forthPlacePointText.GetComponent<Text>().text = friendsOnLeaderboard[4 - 3]+"";
        fifthPlacePointText.GetComponent<Text>().text = friendsOnLeaderboard[4 - 4]+"";
        //POINT TO TEXT DONE
       
        nordinPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(nordinPoints);
        felixPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(felixPoints);
        gustavPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(gustavPoints);
        kristianPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(kristianPoints);
        yourPlaceOnLeaderboard = friendsOnLeaderboard.IndexOf(yourPoints);


        //PERSON TEXT (TOP 5)
        namesInRow[nordinPlaceOnLeaderboard] = "Nordin";
        namesInRow[gustavPlaceOnLeaderboard] = "Gustav";
        namesInRow[felixPlaceOnLeaderboard] = "Felix";
        namesInRow[kristianPlaceOnLeaderboard] = "Kristian";
        namesInRow[yourPlaceOnLeaderboard] = "YOU";

        fifthPlaceNameText.GetComponent<Text>().text = namesInRow[0];
        forthPlaceNameText.GetComponent<Text>().text = namesInRow[1];
        thirdPlaceNameText.GetComponent<Text>().text = namesInRow[2];
        secoundPlaceNameText.GetComponent<Text>().text = namesInRow[3];
        firstPlaceNameText.GetComponent<Text>().text = namesInRow[4];
        //PERSON TEXT DONE

        picInRow[nordinPlaceOnLeaderboard] = nordinPicture;
        picInRow[gustavPlaceOnLeaderboard] = gustavPicture;
        picInRow[felixPlaceOnLeaderboard] = felixPicture;
        picInRow[kristianPlaceOnLeaderboard] = kristianPicture;
        picInRow[yourPlaceOnLeaderboard] = yourPicture;

        Array.Reverse(picInRow);
        
        for (int i = 0; i < friendsOnLeaderboard.Count+1; i++)
        {
            RectTransform picture = picInRow[i].GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(-600,-50*i-5);

            if(i == 1)
            {
                box1.sprite = picInRow[i].sprite;
            }
            if (i == 2)
            {
                box2.sprite = picInRow[i].sprite;
            }
            if (i == 3)
            {
                box3.sprite = picInRow[i].sprite;
            }
        }

    }
    public void AddPoints()
    {
        yourPoints += yourPointsAdd;
        friendsOnLeaderboard[yourPlaceOnLeaderboard] = yourPoints;
    }
}
