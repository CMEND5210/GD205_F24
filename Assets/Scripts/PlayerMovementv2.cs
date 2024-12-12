using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class PlayerMovementv2 : MonoBehaviour
{
    public Transform death;
    public GameObject[] board;
    public GameObject[] spin;
  //public AudioSource audi;
    //We create all of the public variables that we use in this script.
    //We create a public Transform variable called death.
    //We create an array of GameObjects named board.
    //We create an array of GameObjects named spin.

    // Start is called before the first frame update
    void Start()
    {
      //audi = GetComponent<AudioSource>();
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
          //audi.Play();
            Destroy(gameObject);
        }
        //Destroys the player if they run into an enemy;
        for (int i = 0; i < board.Length; i++)
            //We create a for loop for our board array.
        {
            if (transform.position.x == board[i].transform.position.x && transform.position.z == board[i].transform.position.z)
            {
                Debug.Log("You are on " + i + " " + board[i].name);

              //Destroy(board[i]);
            }
            //We get the index of the board that we are on when the player's X & Z position are equal to the board's X & Z position.
         
        }

        for (int i = 0; i < spin.Length; i++) 
            //We create a for loop for our spin array.
        {
            if (transform.position.x == spin[i].transform.position.x && transform.position.z == spin[i].transform.position.z) 
                //We create a conditional statement when the player's X & Z position are equal to the spin's X & Z position.
            {
                
            }
        }

        if (transform.position.x < board[0].transform.position.x)
        {
            Destroy(gameObject);
        }
        //Destroys the player if they fall off the board.
        if (transform.position.x > board[24].transform.position.x)
        {
            Destroy(gameObject);
        }
        //Destroys the player if they fall off the board.
        if (transform.position.z > board[0].transform.position.z)
        {
            Destroy(gameObject);
        }
        //Destroys the player if they fall off the board.
        if (transform.position.z < board[24].transform.position.z)
        {
            Destroy(gameObject);
        }
        //Destroys the player if they fall off the board.
    }
}
