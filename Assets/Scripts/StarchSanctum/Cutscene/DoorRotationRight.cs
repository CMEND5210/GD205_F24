//Part of this code is borrowed from Ketra Games from YouTube, as well as from fellow student Jaiden.
//https://www.youtube.com/watch?v=cecD66fZ_4c
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class DoorRotationRight : MonoBehaviour
{
    public float TimeUntilRotate = 2f;
    //We create our variables that we will use for our scene.
    //We create a float to rotate the door, named TimeUntilRotate, which is equal to 2f.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TimeUntilRotate -= Time.deltaTime;
        //We subtract our float by Time.deltaTime.
        //Or by the amount of time that has passed.

        if (TimeUntilRotate <= 0)
            //We create a conditional statement that will be true when TimeUntilRotate is less than or equal to 0.
        {
            transform.rotation = Quaternion.AngleAxis(-90f, Vector3.up);
            //We rotate the gameObject on the Y axis by 90 degrees.
            transform.position = new Vector3(1.2f, 1.4f, -5f);
            //Then we warp the gameObject to -1.2, 1.4, -5.
        }
    }
}
