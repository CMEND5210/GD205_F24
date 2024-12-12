using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//We call all the libraries we are using here.
//We are using the default Unity libraries, as well as UnityEngine.AI.

public class SillyNav : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent MokapAgent;
    //Here we create the variables that we will use in this script.
    //We create a NavMeshAgent named MokapAgent.

    void Start()
    {
        MokapAgent = GetComponent<NavMeshAgent>();
        //We define our MokapAgent by getting the NavMeshAgent of the gameObject that this script is attached to.
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetInteger("Walk", 0);
        //Here we get the Walk integer that we set up in the animator.
        //And set it to 0.
        //Triggering the Idle animation.

        Ray pointer = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Every frame, we make a Ray called pointer, that is equal to the mouse's position on the game screen.
        RaycastHit pointerImpactReport = new RaycastHit();
        //Then we create a new RaycastHit variable called pointerImpactReport.

        if (Physics.Raycast(pointer, out pointerImpactReport))
            //We create a conditional statement that will be true whenever the ray hits a collider.
        {
            if (Input.GetKey(KeyCode.Mouse0))
                //We create a conditional statement that will be true whenever the left mouse button is clicked.
            {
                MokapAgent.SetDestination(pointerImpactReport.point);
                //We set the NavMeshAgent's destination to the point at which the ray hit.
                if (gameObject.transform.position != pointerImpactReport.point)
                    //We create a conditional statement that will be true whenever the gameObject's transform.position is NOT equal to the transform.position of the point that we clicked on.
                {
                    GetComponent<Animator>().SetInteger("Walk", 1);
                    //We get the Walk integer that we set up in the animator.
                    //And set it to 1.
                    //Triggering the Walking animation.
                }
            }
        }
    }
}
