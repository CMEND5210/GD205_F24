//This code is borrowed from Christina Creates Games and Ketra Games on YouTube.
//https://www.youtube.com/watch?v=6y4_jwZNYMQ
//https://www.youtube.com/watch?v=cecD66fZ_4c
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//We call all the libraries we are using here.
//We are using the default Unity libraries as well as UnityEngine.UI.

public class BookResourceBar : MonoBehaviour
{
    float TimeUntilScan = 1f;
    //We create a float variable named TimeUntilScan, which is equal to 1f.

    [SerializeField]
    int CurrentBookAmount = 10;
    //We create two int variables, one named CurrentBookAmount, which is equal to 10.
    int MaximumBookAmount = 10;
    //And another named MaximumBookAmount, which is also equal to 10.
    GameObject[] Potatoes;
    Transform exitPlace;
    //We create an array of GameObject named Potatoes.
    //And a Transform variable named exitPlace.

    public Image bar;
    //Finally, we create a public Image variable, named bar.

    // Start is called before the first frame update
    void Start()
    {
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        exitPlace = GameObject.FindGameObjectWithTag("ExitPlace").transform;
        //At the start, we define our Potatoes and exitPlace variables to look for GameObjects with the tags "Potato" & "ExitPlace" respectively.
        UpdateBar();
        //Then we run the UpdateBar function.
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
            //We define our Potatoes variable to look for GameObjects with the tag "Potato"
            TimeUntilScan = 1f;
            //Then we set the TimeUntilScan back to 1f;
        }

        for (int i = 0; i < Potatoes.Length; i++)
            //We create a for loop for our Potatoes array.
        {
            if (Potatoes[i].transform.position.x == exitPlace.transform.position.x && Potatoes[i].transform.position.z == exitPlace.transform.position.z && Potatoes[i].GetComponent<Renderer>().material.color == Potatoes[i].GetComponent<PotatoMovement>().AngryColor)
                //We create a conditional statement that will be true whenever a Potatoes X & Z position are equal to the exitPlace's X & Z position.
                //As well as whenever the Potato's renderer's material color is equal to AngryColor.
            {
                CurrentBookAmount -= 1;
                //We subtract one from the CurrentBookAmount
                Destroy(Potatoes[i]);
                //Then destroy the Potato that meets these conditions to not have this part of the script run multiple times.
                UpdateBar();
                //Then we use the UpdateBar function.
            }
        }
    }

    void UpdateBar()
        //We use the UpdateBar function to fill the bar.
    {
        float FillAmount = (float)CurrentBookAmount / MaximumBookAmount;
        //We create a float named FillAmount.
        //That is equal to the float of the CurrentBookAmount divided by the MaximumBookAmount.
        bar.fillAmount = FillAmount;
        //Then we set the bar's fill amount equal to the float we just created.
    }
}
