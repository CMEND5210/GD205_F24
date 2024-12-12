//Part of this code is borrowed from Ketra Games and MoreBBlakeyyy from YouTube, as well as from fellow student Jaiden.
//https://www.youtube.com/watch?v=cecD66fZ_4c
//https://www.youtube.com/shorts/YVATrLTZZTk
//https://github.com/HurriHydra/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//We call all the libraries we are using here.
//We are using the default Unity libraries, as well as UnityEngine.SceneManagement.

public class DoorRotationLeft : MonoBehaviour
{
    public float TimeUntilRotate = 2f;
    float TimeUntilSceneChange = 6f;
    public string Level;
    //We create our variables that we will use for our scene.
    //We create two floats, one to rotate the door, named TimeUntilRotate, which is equal to 2f.
    //And one to change the scene, named TimeUntilSceneChange, which is equal to 6f.
    //We also create a public string variable, named Level.
    //That will be the name of the scene that we want to switch to.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeUntilRotate -= Time.deltaTime;
        TimeUntilSceneChange -= Time.deltaTime;
        //We subtract both of our floats by Time.deltaTime.
        //Or by the amount of time that has passed.

        if (TimeUntilRotate <= 0)
            //We create a conditional statement that will be true when TimeUntilRotate is less than or equal to 0.
        {
            transform.rotation = Quaternion.AngleAxis(90f, Vector3.up);
            //We rotate the gameObject on the Y axis by 90 degrees.
            transform.position = new Vector3(-1.2f, 1.4f, -5f);
            //Then we warp the gameObject to -1.2, 1.4, -5.
        }

        if (TimeUntilSceneChange <= 0)
            //We create a conditional statement that will be true when TimeUntilSceneChange is less than or equal to 0.
        {
            SceneManager.LoadScene(Level);
            //We use the SceneManger to load the scene with the Level variable.
            //Or we load the scene we want using the scene's name.
        }
    }
}
