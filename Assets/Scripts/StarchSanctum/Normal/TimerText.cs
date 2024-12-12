//This code is mostly borrowed from RonnyKibet from Unity.
//https://discussions.unity.com/t/time-counter-up/21195/6
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//We call all the libraries we are using here.
//We are using the default Unity libraries, as well as TMPro.

public class TimerText : MonoBehaviour
{
    float milliSecondsCount;
    int minutesCount;
    //We create all of the private variables that we will use.
    //We create a float variable called milliSecondsCount.
    //And an int variable called minutesCount.

    public TMP_Text text;
    //We create all of the public variables that we will use.
    //We create a TMP_Text called text.

    // Update is called once per frame
    void Update()
    {
        milliSecondsCount += Time.deltaTime;
        milliSecondsCount = Mathf.Round(milliSecondsCount * 100f) / 100f;
        //We add Time.deltaTime to the milliSecondsCount variable.
        //Or the amount of time that has passed.
        //We also round to the hundreths decimal place.
        text.text = "0" + minutesCount + ":" + "0" + milliSecondsCount;
        //We set our text to display like a stopwatch would. 00:00.00

        if (milliSecondsCount >= 60f)
            //We create a conditional statement whenever milliSecondsCount is greater than or equal to 60f.
        {
            minutesCount++;
            //We add one to the minutesCount.
            milliSecondsCount = 0f;
            //Then set the milliSecondsCount back to 0.
        }

        if (milliSecondsCount >= 10f)
            //We create a conditional statement whenever milliSecondsCount is greater than or equal to 10f.
        {
            text.text = "0" + minutesCount + ":" + milliSecondsCount;
            //We set the text to display like a stopwatch would. 00:10.00.
        }

        if (minutesCount >= 10f && milliSecondsCount >= 10f)
            //We create a conditional statement whenever minutesCount & milliSecondsCount is greater than or equal to 10f.
        {
            text.text = minutesCount + ":" + milliSecondsCount;
            //We set the text to display like a stopwatch would. 10:10.00.
        }

        else if (minutesCount >= 10f && milliSecondsCount < 10f)
            //We create an else conditional statement whenever minutesCount is greater than or equal to 10f.
            //And milliSecondsCount is less than 10f.
        {
            text.text = minutesCount + ":" + "0" + milliSecondsCount;
            //We set the text to display like a stopwatch would. 10:00.00.
        }
    }
}
