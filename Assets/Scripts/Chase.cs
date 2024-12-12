using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class Chase : MonoBehaviour
{
    Rigidbody rb;
    //We create our private Rigidbody variable.
    //And name it rb.
    public Transform rascal;
    //We create our public Transform variable.
    //And name it rascal.

    public float forceMultiplier = 15f;
    //We create our public float variable.
    //We set the float to be 15f, and name it forceMultiplier.

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //At the start, we define our Rigidbody variable by getting the Rigidbody of the GameObject that this script is attached to.
    }

    // Update is called once per frame
    void FixedUpdate()
        //We use FixedUpdate because we are dealing with Physics based movement.
    {
        Vector3 rascalOffset = rascal.position - transform.position;
        //We create a Vector3, named rascalOffset.
        //And subtract the target position, or rascal's position, by the position of this gameObject. 
        Vector3 rascalDirection = Vector3.Normalize(rascalOffset);
        //We create a Vector3, named rascalDirection.
        //Then normalize the rascalOffset, giving the gameObject the direction it must go.
        rb.AddForce(rascalDirection * forceMultiplier);
        //We add a force to our Rigidbody, equal to the rascalDirection times our forceMultiplier.
    }
}
