using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PotatoSneakHard : MonoBehaviour
{
    NavMeshAgent PotatoAgent;

    GameObject[] bookshelvesPlaces;
    Transform checkPlace;
    Transform exitPlace;

    public float Decider;

    // Start is called before the first frame update
    void Start()
    {
        PotatoAgent = GetComponent<NavMeshAgent>();

        bookshelvesPlaces = GameObject.FindGameObjectsWithTag("BookshelvesMarkers");
        checkPlace = GameObject.FindGameObjectWithTag("CheckPlace").transform;
        exitPlace = GameObject.FindGameObjectWithTag("ExitPlace").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < bookshelvesPlaces.Length; i++)
        {
            if (gameObject.transform.position.x == bookshelvesPlaces[i].transform.position.x && gameObject.transform.position.z == bookshelvesPlaces[i].transform.position.z)
            {
                Decider = Random.Range(0f, 1f);
                if (Decider <= 0.5f)
                {
                    PotatoAgent.SetDestination(exitPlace.transform.position);
                    Debug.Log("The Potato is getting away!");
                }

                else
                {
                    PotatoAgent.SetDestination(checkPlace.transform.position);
                }
            }
        }
    }
}