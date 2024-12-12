using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We call all the libraries we are using here.
//We are just using the default Unity libraries.

public class OpticBlast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Every frame, we make a Ray called laser, that is equal to the mouse's position on the game screen.
        RaycastHit laserImpactReport = new RaycastHit();
        //Then we create a new RaycastHit variable called laserImpactReport.

        if (Physics.Raycast(laser, out laserImpactReport))
            //We create a conditional statement that will be true whenever the ray hits a collider.
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                //We create a conditional statement that will be true whenever the left mouse button is clicked.
            {
                Destroy(laserImpactReport.collider.gameObject);
                //We destroy the gameObject that the ray hit.
            }

            if (Input.GetKey(KeyCode.Mouse1))
                //We create a conditional statement that will be true whenever the right mouse button is clicked.
            {
                laserImpactReport.rigidbody.AddExplosionForce(25f, laserImpactReport.point, 15f, 5f);
                //We add an explosive force to the gameObject that the ray hit.
            }

            if (Input.GetKeyDown(KeyCode.D))
                //We create a conditional statement that will be true whenever the D button is pressed.
            {
                Instantiate(laserImpactReport.collider.gameObject);
                //We make a clone of the gameObject that the ray hit.
            }
        }
    }
}
