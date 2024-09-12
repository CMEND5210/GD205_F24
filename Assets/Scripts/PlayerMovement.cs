using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform death;
    Vector3 beginAnew;

    // Start is called before the first frame update
    void Start()
    {
        beginAnew = transform.position;
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
            transform.position += new Vector3(0f, 1f, 0f);
            Debug.Log("Congrats! You pressed E!");
        }
    //Moves the GameObject 1 unit positive along the Y-axis when the "e" key is pressed.

        if (Input.GetKeyDown("q"))
        {
            transform.position -= new Vector3(0f, 1f, 0f);
            Debug.Log("Congrats! You pressed Q!");
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
    }
}
