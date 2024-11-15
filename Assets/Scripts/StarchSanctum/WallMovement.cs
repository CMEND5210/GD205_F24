using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// Start by calling all of the libraries that we are going to use.
// These are the default libraries, with UnityEngine.AI added because we are using a NavMeshAgent.

public class WallMovement : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshSurface WallNavMesh;
    // Get all of the private variables that we are going to use in this script.
    // We are using a NavMeshSurface to bake and update our bake as the wall moves.

    public GameObject Potato;
    public Transform[] bookshelvesPlaces;
    // Then get all of the public variables that we will use.
    // We are using a GameObject that will act as the Potato.
    // And an array of Transforms that will be the bookshelvesPlaces.

    void Awake()
        // We are using the Awake function instead of the Start function so that this function will run first.
        // Before the Start function of our Potato movement.
    {
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
        for (int i = 0; i < bookshelvesPlaces.Length; i++)
            // We create a for loop for our bookshelvesPlaces.
        {
            if (Potato.transform.position.x == bookshelvesPlaces[i].transform.position.x)
                // We create a conditional statement that will be true whenever the Potato's X position is equal to the bookshelvesPlaces X position.
            {
                if (bookshelvesPlaces[i] == bookshelvesPlaces[0])
                    // We create a set of conditional statements that will be run once the Potato reaches its destination.
                    // This conditional statement will be true whenever the index of the bookshelfPlace we are on is equal to bookshelvesPlaces[0].
                    // Or the first bookshelfPlace in the array.
                {
                    transform.position -= new Vector3(1f, 0f, 0f);
                    // We move the wall one unit to the left on the X axis to show the imbalance between the bookcases.
                    Potato.transform.position -= new Vector3(.1f, 0f, 0f);
                    // Then we move the Potato a one tenth unit to the left on the X axis to make the conditional statement false.
                    // Making the wall movement only happen once.
                    WallNavMesh.BuildNavMesh();
                    // Then we use the NavMeshSurface to update the NavMesh.
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[1])
                    // This conditional statement will be true whenever the index of the bookshelfPlace we are on is equal to bookshelvesPlaces[1].
                    // Or the second bookshelfPlace in the array.
                {
                    transform.position -= new Vector3(1f, 0f, 0f);
                    // We move the wall one unit to the left on the X axis to show the imbalance between the bookcases.
                    Potato.transform.position -= new Vector3(.1f, 0f, 0f);
                    // Then we move the Potato a one tenth unit to the left on the X axis to make the conditional statement false.
                    // Making the wall movement only happen once.
                    WallNavMesh.BuildNavMesh();
                    // Then we use the NavMeshSurface to update the NavMesh.
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[2])
                    // This conditional statement will be true whenever the index of the bookshelfPlace we are on is equal to bookshelvesPlaces[2].
                    // Or the third bookshelfPlace in the array.
                {
                    transform.position += new Vector3(1f, 0f, 0f);
                    // We move the wall one unit to the right on the X axis to show the imbalance between the bookcases.
                    Potato.transform.position += new Vector3(.1f, 0f, 0f);
                    // Then we move the Potato a one tenth unit to the right on the X axis to make the conditional statement false.
                    // Making the wall movement only happen once.
                    WallNavMesh.BuildNavMesh();
                    // Then we use the NavMeshSurface to update the NavMesh.
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[3])
                    // This conditional statement will be true whenever the index of the bookshelfPlace we are on is equal to bookshelvesPlaces[3].
                    // Or the fourth bookshelfPlace in the array.
                {
                    transform.position += new Vector3(1f, 0f, 0f);
                    // We move the wall one unit to the right on the X axis to show the imbalance between the bookcases.
                    Potato.transform.position += new Vector3(.1f, 0f, 0f);
                    // Then we move the Potato a one tenth unit to the right on the X axis to make the conditional statement false.
                    // Making the wall movement only happen once.
                    WallNavMesh.BuildNavMesh();
                    // Then we use the NavMeshSurface to update the NavMesh.
                }
            }
        }
    }
}
