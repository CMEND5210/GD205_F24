using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class PlayerMovement : MonoBehaviour
{
    public Transform death;
    Vector3 beginAnew;
    public Camera cam;
    public GameObject step;
    //We call all the public and private variable that we will use.
    //We create a public Transform variable named death.
    //We create a Vector3 variable named beginAnew.
    //We create a public Camera variable named cam.
    //And a public GameObject variable named step.


    // Start is called before the first frame update
    void Start()
    {
        beginAnew = transform.position;
        //At the start of the game, we set the Vector3 variable equal to the gameObject's current transform.position.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            transform.position += new Vector3(1f, 0f, 0f);
            Debug.Log("Congrats! You pressed D!");
        }
    //Moves the GameObject 1 unit positive along the X-axis when the "d" key is pressed.

        if (Input.GetKeyDown("a"))
        {
            transform.position -= new Vector3(1f, 0f, 0f);
            Debug.Log("Congrats! You pressed A!");
        }
    //Moves the GameObject 1 unit negative along the X-axis when the "a" key is pressed.

        if (Input.GetKeyDown("e"))
        {
            transform.position += new Vector3(0f, 9f, 0f);
            Debug.Log("Congrats! You pressed E!");
            cam.transform.position += new Vector3(0f, 9f, 0f);
        }
    //Moves the GameObject 1 unit positive along the Y-axis when the "e" key is pressed.

        if (Input.GetKeyDown("q"))
        {
            transform.position -= new Vector3(0f, 9f, 0f);
            Debug.Log("Congrats! You pressed Q!");
            cam.transform.position -= new Vector3(0f, 9f, 0f);
        }
    //Moves the GameObject 1 unit negative along the Y-axis when the "q" key is pressed.

        if (Input.GetKeyDown("w"))
        {
            transform.position += new Vector3(0f, 0f, 1f);
            Debug.Log("Congrats! You pressed W!");
        }
    //Moves the GameObject 1 unit positive along the Z-axis when the "w" key is pressed.

        if (Input.GetKeyDown("s"))
        {
            transform.position -= new Vector3(0f, 0f, 1f);
            Debug.Log("Congrats! You pressed S!");
        }
    //Moves the GameObject 1 unit negative along the Z-axis when the "s" key is pressed.
        if (transform.position == death.position)
        {
            transform.position = beginAnew;
        }
    //Places the player back to their starting position if they run into an enemy;

        if (transform.position.x == step.transform.position.x && transform.position.z == step.transform.position.z)
        {
            Destroy(step);
        }
    //Destroys the GameObject referenced if the Player's X & Z positions are equal.
    }
}