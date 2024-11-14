using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PotatoMovement : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent PotatoAgent;
    Renderer PotatoRenderer;
    Color PotatoColor;
    Vector3 PotatoStartPlace;

    public GameObject[] Bookshelves;
    public Transform waitPlace;
    public Transform[] bookshelvesPlaces;
    public Transform checkPlace;
    public GameObject Potato;

    void Start()
    {
        PotatoAgent = GetComponent<NavMeshAgent>();
        PotatoRenderer = GetComponent<Renderer>();
        PotatoColor = new Color(0.6226414f, 0.3826481f, 0.1139551f, 1f);
        PotatoStartPlace = transform.position;

        PotatoAgent.SetDestination(waitPlace.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray spell = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit spellImpactReport = new RaycastHit();

        if (Physics.Raycast(spell, out spellImpactReport))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (gameObject.transform.position.x == waitPlace.position.x && spellImpactReport.collider == gameObject.GetComponent<Collider>())
                {
                    PotatoRenderer.material.SetColor("_Color", Color.yellow);
                }

                for (int i = 0; i < Bookshelves.Length; i++)
                {
                    if (PotatoRenderer.material.color == Color.yellow && spellImpactReport.collider == Bookshelves[i].GetComponent<Collider>())
                    {
                        PotatoAgent.SetDestination(bookshelvesPlaces[i].position);
                        PotatoRenderer.material.SetColor("_Color", PotatoColor);
                    }
                }
            }
        }

        for (int i = 0; i < bookshelvesPlaces.Length; i++)
        {
            if (gameObject.transform.position.x == bookshelvesPlaces[i].transform.position.x && gameObject.transform.position.z == bookshelvesPlaces[i].transform.position.z)
            {
                if (bookshelvesPlaces[i] == bookshelvesPlaces[0])
                {
                    PotatoRenderer.material.SetColor("_Color", Color.red);
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[1])
                {
                    PotatoRenderer.material.SetColor("_Color", Color.black);
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[2])
                {
                    PotatoRenderer.material.SetColor("_Color", Color.cyan);
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[3])
                {
                    PotatoRenderer.material.SetColor("_Color", Color.grey);
                }

                PotatoAgent.SetDestination(checkPlace.position);
            }
        }


        if (gameObject.transform.position.x == checkPlace.transform.position.x && gameObject.transform.position.z == checkPlace.transform.position.z)
        {
            PotatoRenderer.material.SetColor("_Color", PotatoColor);

            gameObject.transform.position = PotatoStartPlace;
            PotatoAgent.SetDestination(waitPlace.position);
        }
    }
}
