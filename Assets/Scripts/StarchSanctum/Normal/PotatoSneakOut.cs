using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PotatoSneakOut : MonoBehaviour
{
    NavMeshAgent PotatoAgent;
    Renderer PotatoRenderer;

    Color AngryColor;

    GameObject[] bookshelvesPlaces;
    Transform checkPlace;
    Transform exitPlace;

    float Decider;

    // Start is called before the first frame update
    void Start()
    {
        PotatoAgent = GetComponent<NavMeshAgent>();
        PotatoRenderer = GetComponent<Renderer>();

        AngryColor = new Color(0.471f, 0.024f, 0.024f, 1f);

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
                if (Decider <= 0.3f)
                {
                    PotatoAgent.SetDestination(exitPlace.transform.position);
                    PotatoRenderer.material.SetColor("_Color", AngryColor);
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
