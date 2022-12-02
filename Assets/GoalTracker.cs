using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalTracker : MonoBehaviour
{
    public float goalSet;
    public GameObject inputField;
    public GameObject textDisplay;
    
    public void SetYourGoal()
    {
        goalSet = float.Parse(inputField.GetComponent<Text>().text);
        textDisplay.GetComponent<Text>().text = goalSet + "$";
    }
}
