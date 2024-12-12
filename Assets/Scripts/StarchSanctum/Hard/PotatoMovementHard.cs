using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PotatoMovementHard : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent PotatoAgent;

    GameObject[] Bookshelves;
    Transform waitPlace;
    GameObject[] bookshelvesPlaces;
    Transform checkPlace;
    Transform exitPlace;
    GameObject[] Potatoes;

    public int WantedBook;
    float TimeUntilScan = 1f;

    void Start()
    {
        PotatoAgent = GetComponent<NavMeshAgent>();

        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        Bookshelves = GameObject.FindGameObjectsWithTag("Bookshelves");
        waitPlace = GameObject.FindGameObjectWithTag("WaitPlace").transform;
        bookshelvesPlaces = GameObject.FindGameObjectsWithTag("BookshelvesMarkers");
        checkPlace = GameObject.FindGameObjectWithTag("CheckPlace").transform;
        exitPlace = GameObject.FindGameObjectWithTag("ExitPlace").transform;

        WantedBook = Random.Range(0, 4);

        PotatoAgent.SetDestination(waitPlace.position);
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

        Ray spell = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit spellImpactReport = new RaycastHit();

        if (Physics.Raycast(spell, out spellImpactReport))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                for (int i = 0; i < Bookshelves.Length; i++)
                {
                    if (spellImpactReport.collider == Bookshelves[i].GetComponent<Collider>())
                    {
                        if (spellImpactReport.collider == Bookshelves[WantedBook].GetComponent<Collider>())
                        {
                            PotatoAgent.SetDestination(bookshelvesPlaces[WantedBook].transform.position);
                        }

                        else
                        {
                            Destroy(gameObject);
                        }
                    }
                }
                for (int j = 0; j < Potatoes.Length; j++)
                {
                    if (spellImpactReport.collider == Potatoes[j].GetComponent<Collider>() && Potatoes[j].GetComponent<PotatoSneakHard>().Decider <= 0.5f)
                    {
                        Potatoes[j].GetComponent<NavMeshAgent>().SetDestination(checkPlace.transform.position);
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                for (int j = 0; j < Potatoes.Length; j++)
                {
                    if (spellImpactReport.collider == Potatoes[j].GetComponent<Collider>())
                    {
                        Destroy(Potatoes[j]);
                    }
                }
            }
        }

        if (gameObject.transform.position.x == checkPlace.transform.position.x && gameObject.transform.position.z == checkPlace.transform.position.z)
        {
            PotatoAgent.SetDestination(exitPlace.transform.position);
        }

        if (gameObject.transform.position.x == exitPlace.transform.position.x && gameObject.transform.position.z == exitPlace.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
