using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class TargetPosition : MonoBehaviour
{
    public float Movement;
    //We create all of the variables that we will use in this script.
    //We create a public float variable, named Movement.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Movement, 0f, 0f);
        //Every frame, our Movement variable is added to the gameObject's X position.
    }

    private void OnTriggerEnter(Collider col)
        //We create the OnTriggerEnter function whenever we collide with a trigger.
    {
        if (col.tag == "LeftWarp")
            //We create a conditional statement that will be true whenever the trigger's tag is "LeftWarp"
        {
            transform.position = new Vector3(12f, 4f, 0f);
            //We warp the gameObject to 12, -4, 0.
        }

        if (col.tag == "RightWarp")
            //We create a conditional statement that will be true whenever the trigger's tag is "RightWarp"
        {
            transform.position = new Vector3(-12f, 0f, 0f);
            //We warp the gameObject to -12, 0, 0.
        }
    }
}
