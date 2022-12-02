using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool IsOptionsOpen;
    public GameObject gameObject;
    
    private float currentDelayTime = 0.5f;
    private float delayTime = 0.5f;
    public int number = 1;

    
    public void OpenOption()
    {
        if (IsOptionsOpen == false && currentDelayTime <= 0 && number == 1)
        {
            currentDelayTime = delayTime;
            gameObject.SetActive(true);

            IsOptionsOpen = true;
            print(IsOptionsOpen);
            print("OPTION OPNED::::::::::::::::::::::::::::::::::");
        }
        else
        {
            currentDelayTime -= Time.deltaTime;
        }
    }
    public void CloseOptions()
    {
        if (IsOptionsOpen == true && currentDelayTime <= 0 && number == 2) ;
        {
            currentDelayTime = delayTime;
            gameObject.SetActive(false);

            IsOptionsOpen = false;
            print(IsOptionsOpen);
            print("OPTION CLOSED::::::::::::::::::::::::::::");
        }

    }
    void Update()
    {
        print(currentDelayTime);
        currentDelayTime -= Time.deltaTime;
        print("NUMBER IS::::::::::::::::::::::::::::::::::::::" + number);
    }
}
