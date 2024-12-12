using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class PhysicsMovement : MonoBehaviour
{
    Rigidbody rb;
    //We create our private Rigidbody variable.
    //And name it rb.

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //At the start, we define our Rigidbody variable by getting the Rigidbody of the GameObject that this script is attached to.
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
        //We use FixedUpdate because we are dealing with Physics based movement.
    {
        if (Input.GetKey(KeyCode.W))
            //We create a conditional statement true whenever the W key is held down.
        {
            rb.AddForce(0f, 0f, 1f, ForceMode.Impulse);
            //We add a force to other rigidbody 1f along the Z-axis, using the Impulse ForceMode.
            //Or an instant force impulse to the rigidbody, using its mass.
        }

        if (Input.GetKey(KeyCode.S))
            //We create a conditional statement true whenever the S key is held down.
        {
            rb.AddForce(0f, 0f, -1f, ForceMode.Impulse);
            //We add a force to other rigidbody -1f along the Z-axis, using the Impulse ForceMode.
            //Or an instant force impulse to the rigidbody, using its mass.
        }

        if (Input.GetKey(KeyCode.A))
            //We create a conditional statement true whenever the S key is held down.
        {
            rb.AddForce(-1f, 0f, 0f, ForceMode.Impulse);
            //We add a force to other rigidbody -1f along the X-axis, using the Impulse ForceMode.
            //Or an instant force impulse to the rigidbody, using its mass.
        }

        if (Input.GetKey(KeyCode.D))
            //We create a conditional statement true whenever the D key is held down.
        {
            rb.AddForce(1f, 0f, 0f, ForceMode.Impulse);
            //We add a force to other rigidbody -1f along the X-axis, using the Impulse ForceMode.
            //Or an instant force impulse to the rigidbody, using its mass.
        }

        if (Input.GetKey(KeyCode.Q))
            //We create a conditional statement true whenever the Q key is held down.
        {
            rb.AddForce(0f, -1f, 0f, ForceMode.Impulse);
            //We add a force to other rigidbody -1f along the Y-axis, using the Impulse ForceMode.
            //Or an instant force impulse to the rigidbody, using its mass.
        }

        if (Input.GetKey(KeyCode.E))
            //We create a conditional statement true whenever the E key is held down.
        {
            rb.AddForce(0f, 1f, 0f, ForceMode.Impulse);
            //We add a force to other rigidbody 1f along the Y-axis, using the Impulse ForceMode.
            //Or an instant force impulse to the rigidbody, using its mass.
        }
    }

    void OnCollisionEnter(Collision damageReport)
        //We create a function named OnCollisionEnter, for whenever an object collides with another.
    {
        if (damageReport.gameObject.tag == "Terrain")
            //We create a conditional statement that will be true whenever the collider's tag is Terrain.
        {
            Destroy(gameObject);
            //We destroy the gameObject that this script is attached to.
        }

        if (damageReport.gameObject.tag == "Mother")
            //We create a conditional statement that will be true whenever the collider's tag is Mother.
        {
            Destroy(gameObject);
            //We destroy the gameObject that this script is attached to.
        }

        if (damageReport.transform.localScale.magnitude > gameObject.transform.localScale.magnitude)
            //We create a conditional statement that will be true whenever the magnitude of the collider's scale is greater than the magnitude of our gameObject's scale.
        {
            Destroy(gameObject);
            //We destroy the gameObject that this script is attached to.
        }

        if (damageReport.transform.localScale.magnitude <= gameObject.transform.localScale.magnitude)
            //We create a conditional statement that will be true whenever the magnitude of the collider's scale is greater than the magnitude of our gameObject's scale.
        {
            Destroy(damageReport.gameObject);
            //We destroy the gameObject that we collided with.
            gameObject.transform.localScale += damageReport.transform.localScale;
            //Then we add the scale of the object we destroy to the gameObject this script is attached to.
        }
    }
}
