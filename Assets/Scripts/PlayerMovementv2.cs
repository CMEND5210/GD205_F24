using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementv2 : MonoBehaviour
{

    public Transform death;
    public GameObject[] board;
    public GameObject[] spin;
  //public AudioSource audi;

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

        if (Input.GetKeyDown("a"))
        {
            transform.position -= new Vector3(1f, 0f, 0f);
            Debug.Log("Congrats! You pressed A!");
        }

        if (Input.GetKeyDown("w"))
        {
            transform.position += new Vector3(0f, 0f, 1f);
            Debug.Log("Congrats! You pressed W!");
        }

        if (Input.GetKeyDown("s"))
        {
            transform.position -= new Vector3(0f, 0f, 1f);
            Debug.Log("Congrats! You pressed S!");
        }

        if (transform.position == death.position)
        {
          //audi.Play();
            Destroy(gameObject);
        }

        for (int i = 0; i < board.Length; i++)
        {
            if (transform.position.x == board[i].transform.position.x && transform.position.z == board[i].transform.position.z)
            {
                Debug.Log("You are on " + i + " " + board[i].name);

              //Destroy(board[i]);
            }

         
        }

        for (int i = 0; i < spin.Length; i++) 
        {
            if (transform.position.x == spin[i].transform.position.x && transform.position.z == spin[i].transform.position.z) 
            {
                
            }
        }

        if (transform.position.x < board[0].transform.position.x)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > board[24].transform.position.x)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > board[0].transform.position.z)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < board[24].transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
