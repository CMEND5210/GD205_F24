//This code is borrowed from Rosscoe Tutorials on YouTube.
//https://www.youtube.com/watch?v=dJB07ZSiW7k
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class MaterialSwap : MonoBehaviour
{
    public GameObject player;
    public Material[] checking;
    public Renderer rend;
    //Here we call all of the public variables we will use.
    //We create a GameObject for the player named player.
    //An array of materials to swap between named checking.
    //And a Renderer to render the material named rend.

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        //At the start we define our rend variable by getting the Renderer component of the gameObject this script is attached to.
        rend.sharedMaterial = checking[0];
        //Then we set the renderer's shared material to the first index in our material array.
        //Or the material we want rendered at the start.
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == player.transform.position.x && transform.position.z == player.transform.position.z)
            //We create a conditional statement for when this gameObject's X & Z position are equal to the player's X & Z position;
        {
            rend.sharedMaterial = checking[1];
            //We change the renderer's shared material to the second index in our material array.
        }
    }
}
