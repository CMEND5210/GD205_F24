using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// Start by calling all of the libraries that we are going to use.
// These are the default libraries, with UnityEngine.AI added because we are using a NavMeshAgent.

public class WallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float TimeUntilScan = 1f;
    NavMeshSurface WallNavMesh;
    // Get all of the private variables that we are going to use in this script.
    // We are using a NavMeshSurface to bake and update our bake as the wall moves.

    GameObject[] Potatoes;

    public Transform[] bookshelvesPlaces;
    // Then get all of the public variables that we will use.
    // We are using a GameObject that will act as the Potato.
    // And an array of Transforms that will be the bookshelvesPlaces.

    void Awake()
        // We are using the Awake function instead of the Start function so that this function will run first.
        // Before the Start function of our Potato movement.
    {
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        WallNavMesh = GetComponent<NavMeshSurface>();
        WallNavMesh.BuildNavMesh();
        // When the game starts, we will define the private variable we need for this script.
        // We get the NavMeshSurface component for our WallNavMesh.
        // Then, we use that NavMeshSurface we got to build a NavMesh.
    }

    // Update is called once per frame
    void FixedUpdate()
        // Used FixedUpdate since we are using Physics-based movement.
    {
        TimeUntilScan -= Time.deltaTime;
        if (TimeUntilScan <= 0)
        {
            Potatoes = GameObject.FindGameObjectsWithTag("Potato");
            TimeUntilScan = 1f;
        }

        for (int i = 0; i < Potatoes.Length; i++)
        {
            if (Potatoes[i].transform.position.x == bookshelvesPlaces[0].transform.position.x)
            {
                transform.position -= new Vector3(.5f, 0f, 0f);
                WallNavMesh.BuildNavMesh();
            }

            if (Potatoes[i].transform.position.x == bookshelvesPlaces[1].transform.position.x)
            {
                transform.position -= new Vector3(.5f, 0f, 0f);
                WallNavMesh.BuildNavMesh();
            }

            if (Potatoes[i].transform.position.x == bookshelvesPlaces[2].transform.position.x)
            {
                transform.position += new Vector3(.5f, 0f, 0f);
                WallNavMesh.BuildNavMesh();
            }

            if (Potatoes[i].transform.position.x == bookshelvesPlaces[3].transform.position.x)
            {
                transform.position += new Vector3(.5f, 0f, 0f);
                WallNavMesh.BuildNavMesh();
            }
        }
    }
}
