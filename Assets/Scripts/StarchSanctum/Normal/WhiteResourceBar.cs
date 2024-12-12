//This code is borrowed from Christina Creates Games on YouTube.
//https://www.youtube.com/watch?v=6y4_jwZNYMQ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//We call all the libraries we are using here.
//We are using the default Unity libraries as well as UnityEngine.UI.

public class WhiteResourceBar : MonoBehaviour
{
   public float CurrentWhiteBar = 50f;
   int MaximumBarAmount = 100;
    //We set the numeric variables that we will use in this script.
    //We use a float named CurrentWhiteBar which is equal to 50f.
    //And an integer named MaximumBarAmount which is equal to 100.

    public Image bar;
    public GameObject Wall;
    //We set all the other variables that we will use.
    //We use a public Image named bar.
    //And a public GameObject named Wall.

    // Start is called before the first frame update
    void Start()
    {
        UpdateBar();
        //At the start, we run the UpdateBar function.
    }

    // Update is called once per frame
    void Update()
    {
        if (Wall.transform.position.x <= -9)
        {
            CurrentWhiteBar = 0f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -8.5 && Wall.transform.position.x <= -8)
        {
            CurrentWhiteBar = 5.552f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -7.5 && Wall.transform.position.x <= -7)
        {
            CurrentWhiteBar = 11.108f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -6.5 && Wall.transform.position.x <= -6)
        {
            CurrentWhiteBar = 16.664f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -5.5 && Wall.transform.position.x <= -5)
        {
            CurrentWhiteBar = 22.22f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -4.5 && Wall.transform.position.x <= -4)
        {
            CurrentWhiteBar = 27.776f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -3.5 && Wall.transform.position.x <= -3)
        {
            CurrentWhiteBar = 33.332f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -2.5 && Wall.transform.position.x <= -2)
        {
            CurrentWhiteBar = 38.888f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -1.5 && Wall.transform.position.x <= -1)
        {
            CurrentWhiteBar = 44.444f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -0.5 && Wall.transform.position.x <= 0.5)
        {
            CurrentWhiteBar = 50f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 1 && Wall.transform.position.x <= 1.5)
        {
            CurrentWhiteBar = 55.556f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 2 && Wall.transform.position.x <= 2.5)
        {
            CurrentWhiteBar = 61.112f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 3 && Wall.transform.position.x <= 3.5)
        {
            CurrentWhiteBar = 66.668f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 4 && Wall.transform.position.x <= 4.5)
        {
            CurrentWhiteBar = 72.224f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 5 && Wall.transform.position.x <= 5.5)
        {
            CurrentWhiteBar = 77.78f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 6 && Wall.transform.position.x <= 6.5)
        {
            CurrentWhiteBar = 83.336f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 7 && Wall.transform.position.x <= 7.5)
        {
            CurrentWhiteBar = 88.892f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 8 && Wall.transform.position.x <= 8.5)
        {
            CurrentWhiteBar = 94.448f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 9)
        {
            CurrentWhiteBar = 100f;
            UpdateBar();
        }
        //These are a series of conditional statements for every possibility of the wall's position.
        //The position of the wall determines the CurrentWhiteBar's value.
        //Then, we use the UpdateBar function to reflect the change in bar.
    }

    void UpdateBar()
        //We use the UpdateBar function to fill the bar.
    {
        float FillAmount = (float)CurrentWhiteBar / MaximumBarAmount;
        //We create a float named FillAmount.
        //That is equal to the float of the CurrentWhiteBar divided by the MaximumBarAmount.
        bar.fillAmount = FillAmount;
        //Then we set the bar's fill amount equal to the float we just created.
    }
}
