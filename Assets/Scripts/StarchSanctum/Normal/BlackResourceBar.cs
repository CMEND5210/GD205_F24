//This code is borrowed from Christina Creates Games on YouTube.
//https://www.youtube.com/watch?v=6y4_jwZNYMQ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//We call all the libraries we are using here.
//We are using the default Unity libraries as well as UnityEngine.UI.

public class BlackResourceBar : MonoBehaviour
{
    public float CurrentBlackBar = 50f;
    int MaximumBarAmount = 100;
    //We set the numeric variables that we will use in this script.
    //We use a float named CurrentBlackBar which is equal to 50f.
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
            CurrentBlackBar = 100f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -8.5 && Wall.transform.position.x <= -8)
        {
            CurrentBlackBar = 94.448f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -7.5 && Wall.transform.position.x <= -7)
        {
            CurrentBlackBar = 88.892f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -6.5 && Wall.transform.position.x <= -6)
        {
            CurrentBlackBar = 83.336f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -5.5 && Wall.transform.position.x <= -5)
        {
            CurrentBlackBar = 77.78f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -4.5 && Wall.transform.position.x <= -4)
        {
            CurrentBlackBar = 72.224f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -3.5 && Wall.transform.position.x <= -3)
        {
            CurrentBlackBar = 66.668f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -2.5 && Wall.transform.position.x <= -2)
        {
            CurrentBlackBar = 61.112f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -1.5 && Wall.transform.position.x <= -1)
        {
            CurrentBlackBar = 55.556f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -0.5 && Wall.transform.position.x <= 0.5)
        {
            CurrentBlackBar = 50f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 1 && Wall.transform.position.x <= 1.5)
        {
            CurrentBlackBar = 44.444f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 2 && Wall.transform.position.x <= 2.5)
        {
            CurrentBlackBar = 38.888f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 3 && Wall.transform.position.x <= 3.5)
        {
            CurrentBlackBar = 33.332f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 4 && Wall.transform.position.x <= 4.5)
        {
            CurrentBlackBar = 27.776f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 5 && Wall.transform.position.x <= 5.5)
        {
            CurrentBlackBar = 22.22f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 6 && Wall.transform.position.x <= 6.5)
        {
            CurrentBlackBar = 16.664f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 7 && Wall.transform.position.x <= 7.5)
        {
            CurrentBlackBar = 11.108f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 8 && Wall.transform.position.x <= 8.5)
        {
            CurrentBlackBar = 5.552f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 9)
        {
            CurrentBlackBar = 0f;
            UpdateBar();
        }
        //These are a series of conditional statements for every possibility of the wall's position.
        //The position of the wall determines the CurrentBlackBar's value.
        //Then, we use the UpdateBar function to reflect the change in bar.
    }

    void UpdateBar()
        //We use the UpdateBar function to fill the bar.
    {
        float FillAmount = (float)CurrentBlackBar / MaximumBarAmount;
        //We create a float named FillAmount.
        //That is equal to the float of the CurrentBlackBar divided by the MaximumBarAmount.
        bar.fillAmount = FillAmount;
        //Then we set the bar's fill amount equal to the float we just created.
    }
}
