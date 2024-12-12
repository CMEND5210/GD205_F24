using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class AnimationFlip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetInteger("Walk", 0);
        GetComponent<Animator>().SetInteger("Turn", 0);
        //Here we get the Walk and Turn integers that we set up in the animator.
        //And set them both to 0.
        //Triggering the Idle animation.

        if (Input.GetKey(KeyCode.W))
            //We create a conditional statement that is true whenever the W key is held down.
        {
            GetComponent<Animator>().SetInteger("Walk", 1);
            //We get the Walk integer that we set up in the animator.
            //And set it to 1.
            //Triggering the Walking animation.
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetInteger("Turn", -1);
            //We get the Turn integer that we set up in the animator.
            //And set it to -1.
            //Triggering the TurnLeft animation.
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetInteger("Turn", 1);
            //We get the Turn integer that we set up in the animator.
            //And set it to 1.
            //Triggering the TurnRight animation.
        }
    }
}
