//This code is borrowed from Christina Creates Games and Ketra Games on YouTube.
//https://www.youtube.com/watch?v=6y4_jwZNYMQ
//https://www.youtube.com/watch?v=cecD66fZ_4c
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//We call all the libraries we are using here.
//We are using the default Unity libraries as well as UnityEngine.UI.

public class HappinessResourceHard : MonoBehaviour
{
    float TimeUntilScan = 1f;
    //We create a float variable named TimeUntilScan, which is equal to 1f.
    float ActivationTime;
    //We create a float variable named ActivationTime.
    float CurrentHappiness = 100f;
    //We create a float variable, named CurrentHappiness, which is equal to 100f.
    int MaximumHappiness = 100;
    //And an int variable named MaximumHappiness, which is equal to 100.
    GameObject[] Potatoes;
    //We create an array of GameObjects named Potatoes.
    [SerializeField]
    GameObject Potion;
    //We create a GameObject variable named Potion.

    public Image bar;
    //Finally, we create a public Image variable, named bar.

    // Start is called before the first frame update
    void Start()
    {
        ActivationTime = 0f;
        //At the start, we set our ActivationTime variable equal to 0f;
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        //We define our Potatoes variable to look for GameObjects with the tags "Potato".
        UpdateBar();
    }

    // Update is called once per frame
    void Update()
    {
        Ray activator = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Every frame, we make a Ray called activator, that is equal to the mouse's position on the game screen.
        RaycastHit activatorImpactReport = new RaycastHit();
        //Then we create a new RaycastHit variable called activatorImpactReport.
        TimeUntilScan -= Time.deltaTime;
        //We subtract our TimeUntilScan variable by Time.deltaTime.
        //Or by the amount of time that has passed.
        if (TimeUntilScan <= 0)
            //We create a conditional statement that will be true whenever TimeUntilScan is less than or equal to 0f.
        {
            Potatoes = GameObject.FindGameObjectsWithTag("Potato");
            //We define our Potatoes variable to look for GameObjects with the tag "Potato".
            TimeUntilScan = 1f;
            //Then we set the TimeUntilScan back to 1f;
        }

        if (Potatoes.Length > 0)
            //We create a conditional statement that will be true whenever the length of the Potatoes array is greater than 0.
        {
            CurrentHappiness -= 0.005f;
            //We subtract .005f from the CurrentHappiness variable every frame.
            UpdateBar();
            //Then run the UpdateBar function.
        }
        if (Physics.Raycast(activator, out activatorImpactReport))
            //We create a conditional statement that will be true whenever the ray hits a collider.
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                //We create a conditional statement that will be true whenever the left mouse button is clicked.
            {
                if (activatorImpactReport.collider.tag == "Potion" && ActivationTime == 0f)
                    //We create a condition statement that will be true whenever the Collider tag of the RayCastHit is "Potion".
                    //And the ActivationTime float is equal to 0f.
                {
                    CurrentHappiness += 30f;
                    //We add 30f to the CurrentHappiness variable.
                    UpdateBar();
                    //Then we run the UpdateBar function.
                    ActivationTime = 60f;
                    //And set our ActivationTime variable to 60f.
                }
            }
        }
        if (CurrentHappiness > 100f)
            //We create a conditional statement for whenever our CurrentHappiness variable is greater than 100f.
        {
            CurrentHappiness = 100f;
            //We set the CurrentHappiness variable to 100f.
        }

        if (ActivationTime != 0f)
            //We create a conditional statement that will be true whenever the ActivationTime variable is NOT equal to 0f.
        {
            ActivationTime -= Time.deltaTime;
            //We subtract our ActivationTime variable by Time.deltaTime.
            //Or by the amount of time that has passed.

        }

        if (ActivationTime < 0f)
            //We create a conditional statement that will be true whenever the ActivationTime variable is less than 0f.
        {
            ActivationTime = 0f;
            //We set the ActivationTime variable to 0f.
        }
    }
    
    void UpdateBar()
        //We use the UpdateBar function to fill the bar.
    {
        float FillAmount = (float)CurrentHappiness / MaximumHappiness;
        //We create a float named FillAmount.
        //That is equal to the float of the CurrentHappiness divided by the MaximumHappiness.
        bar.fillAmount = FillAmount;
        //Then we set the bar's fill amount equal to the float we just created.
    }
}
