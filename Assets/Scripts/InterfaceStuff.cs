using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class InterfaceStuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GamePause()
        //We create a new function, called GamePause, for our button's on click function.
        //It's important that this function is public so that it is accessible.
    {
        if (Time.timeScale == 1f)
            //We create a conditional statement that will be true whenever the scale of time is equal to 1f.
            //Or normal game speed.
        {
            Time.timeScale = 0f;
            //We set the scale of time to 0f, essentially pausing the game.
        }

        else if (Time.timeScale == 0f)
            //We create an else conditional statement that will be true whenever the scale of time is equal of 0f.
            //Or paused.
        {
            Time.timeScale = 1f;
            //We set the scale of time to 1f, essentially playing the game.
        }
    }
}
