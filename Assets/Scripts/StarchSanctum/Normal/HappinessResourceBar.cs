//This code is borrowed from Christina Creates Games and Ketra Games on YouTube.
//https://www.youtube.com/watch?v=6y4_jwZNYMQ
//https://www.youtube.com/watch?v=cecD66fZ_4c
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//We call all the libraries we are using here.
//We are using the default Unity libraries as well as UnityEngine.UI.

public class HappinessResourceBar : MonoBehaviour
{
    float TimeUntilScan = 1f;
    //We create a float variable named TimeUntilScan, which is equal to 1f.
    float CurrentHappiness = 100f;
    //We create a float variable, named CurrentHappiness, which is equal to 100f.
    int MaximumHappiness = 100;
    //And an int variable named MaximumHappiness, which is equal to 100.
    GameObject[] Potatoes;
    Transform waitPlace;
    //We create an array of GameObjects named Potatoes.
    //And a Transform variable named waitPlace.
    bool HealBar;
    //We create a bool variable named HealBar.

    public Image bar;
    //Finally, we create a public Image variable, named bar.

    // Start is called before the first frame update
    void Start()
    {
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        waitPlace = GameObject.FindGameObjectWithTag("WaitPlace").transform;
        //At the start, we define our Potatoes and exitPlace variables to look for GameObjects with the tags "Potato" & "WaitPlace" respectively.
        UpdateBar();
        //Then we run the UpdateBar function.
        HealBar = true;
        //And we set the HealBar boolean to true.
    }

    // Update is called once per frame
    void Update()
    {
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

        if (HealBar == true)
            //We create a conditional statement for whenever the HealBar boolean is set to true.
        {
            CurrentHappiness += .05f;
            //We add .05f to our CurrentHappiness variable.
            UpdateBar();
            //Then run the UpdateBar function.
        }

        if (CurrentHappiness > 100f)
            //We create a conditional statement for whenever our CurrentHappiness variable is greater than 100f.
        {
            CurrentHappiness = 100f;
            //We set the CurrentHappiness variable to 100f.
        }

        for (int i = 0; i < Potatoes.Length; i++)
            //We create a for loop for our Potatoes array.
        {
            if (Potatoes[i].transform.position.x == waitPlace.transform.position.x && Potatoes[i].transform.position.z == waitPlace.transform.position.z)
                //We create a conditional statement that will be true whenever a Potato's X & Z position are equal to the waitPlace's X & Z position.
            {  
                HealBar = false;
                //We set our HealBar boolean to false.
                CurrentHappiness -= .1f;
                //We subtract .1f from the CurrentHappiness variable every frame.
                UpdateBar();
                //Then run the UpdateBar function.
            }

            else
                //We create an else statement for whenever a Potato's X & Z position are NOT equal to the waitPlace's X & Z position.
            {
                HealBar = true;
                //We set our HealBar boolean to true.
            }
        }
    }

    private void OnTriggerEnter(Collider col)
        //We create the OnTriggerEnter for whenever the Potatoes enter a trigger.
    {
        for (int i = 0; i < Potatoes.Length; i++)
            //We create a for loop for our Potatoes array.
        {
            if (col.tag == "InteractionArea")
                //We create a conditional statement that will be true whenever the tag of the trigger collider is "InteractionArea"
            {
                HealBar = false;
                //We set our HealBar boolean to false.
                CurrentHappiness -= .2f;
                //We subtract .2f from the CurrentHappiness variable every frame.
                UpdateBar();
                //Then run the UpdateBar function.
            }
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
