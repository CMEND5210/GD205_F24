using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PotatoInteraction : MonoBehaviour
{
    float TimeUntilScan = 1f;
    NavMeshAgent PotatoAgent;
    Vector3 PreviousDestination;

    [SerializeField]
    GameObject[] Potatoes;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Collider>().isTrigger = false;
        PotatoAgent = gameObject.GetComponentInParent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeUntilScan -= Time.deltaTime;
        if (TimeUntilScan <= 0)
        {
            Potatoes = GameObject.FindGameObjectsWithTag("Potato");
            TimeUntilScan = 1f;
        }

        for (int i = 0; i < Potatoes.Length; i++)
        {
            if (Potatoes[i].transform.position.z < 0)
            {
                gameObject.GetComponent<Collider>().isTrigger = true;
            }

            if (Potatoes[i].transform.position.z >= 0)
            {
                gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        for (int i = 0; i < Potatoes.Length; i++)
        {
            if (col.tag == "InteractionArea")
            {
                PreviousDestination = PotatoAgent.destination;
                PotatoAgent.SetDestination(Potatoes[i].transform.position);
            }
        }
    }

    void OnTriggerStay(Collider coll)
    {
        for (int i = 0; i < Potatoes.Length; i++)
        {
            Ray Seperator = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit SeperatorReport = new RaycastHit();

            if (Physics.Raycast(Seperator, out SeperatorReport))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    if (coll.GetComponent<Collider>() == Potatoes[i].GetComponent<Collider>())
                    {
                        Potatoes[i].GetComponent<NavMeshAgent>().SetDestination(PreviousDestination);
                    }
                }
            }
        }
    }
}
