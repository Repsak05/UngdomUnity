using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillCirkelGoal : MonoBehaviour
{
    public Image cirkel;
    public GoalTracker goalTracker;
    public MoneyUsed moneyUsed;

    //For text
    public GameObject goalText;
    public float goalMinusMoneyUsed;


    // Update is called once per frame
    void Update()
    {
        FillGoalCirkel();
        ProcentGoal();
    }
    public void FillGoalCirkel()
    {
        cirkel.fillAmount = goalMinusMoneyUsed / goalTracker.goalSet;
    }
    public void ProcentGoal()
    {
        goalMinusMoneyUsed = goalTracker.goalSet - moneyUsed.moneyUsedNow;
        goalText.GetComponent<Text>().text = " Money left: " + goalMinusMoneyUsed;
    }
}
