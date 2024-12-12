//This code is borrowed from Christina Creates Games on YouTube.
//https://www.youtube.com/watch?v=6y4_jwZNYMQ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//We call all the libraries we are using here.
//We are using the default Unity libraries as well as UnityEngine.UI.

public class LightResourceBar : MonoBehaviour
{
    public float CurrentLightBar;
    int MaximumBarAmount = 100;
    //We set the numeric variables that we will use in this script.
    //We use a float named CurrentLightBar.
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
        CurrentLightBar = 50f + (5.556f * Wall.transform.position.x);
        //Every frame, we update the CurrentLightBar to be 50f + The Wall X's position multiplied by 5.556f.
        UpdateBar();
        //Then we use the UpdateBar function.
    }

    void UpdateBar()
        //We use the UpdateBar function to fill the bar.
    {
        float FillAmount = (float)CurrentLightBar / MaximumBarAmount;
        //We create a float named FillAmount.
        //That is equal to the float of the CurrentLightBar divided by the MaximumBarAmount.
        bar.fillAmount = FillAmount;
        //Then we set the bar's fill amount equal to the float we just created.

    }
}
