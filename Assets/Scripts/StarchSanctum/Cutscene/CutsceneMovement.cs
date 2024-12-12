using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CutsceneMovement : MonoBehaviour
{
    NavMeshAgent PotatoAgent;
    GameObject[] Destinations;
    int LuckyDestination;

    // Start is called before the first frame update
    void Start()
    {
        PotatoAgent = GetComponent<NavMeshAgent>();
        Destinations = GameObject.FindGameObjectsWithTag("ExitPlace");
        LuckyDestination = Random.Range(0, Destinations.Length);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PotatoAgent.SetDestination(Destinations[LuckyDestination].transform.position);

        for (int i = 0; i < Destinations.Length; i++)
        {
            if (transform.position.x == Destinations[i].transform.position.x)
            {
                Destroy(gameObject);
            }
        }
    }
}
