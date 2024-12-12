using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WallMovementHard : MonoBehaviour
{
    // Start is called before the first frame update
    float TimeUntilScan = 1f;
    float Movement;
    NavMeshSurface WallNavMesh;
    Rigidbody rb;

    GameObject[] Potatoes;

    public Transform[] bookshelvesPlaces;

    void Awake()
    {
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        WallNavMesh = GetComponent<NavMeshSurface>();
        rb = GetComponent<Rigidbody>();
        WallNavMesh.BuildNavMesh();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray corrector = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit correctorImpactReport = new RaycastHit();

        TimeUntilScan -= Time.deltaTime;
        if (TimeUntilScan <= 0)
        {
            Potatoes = GameObject.FindGameObjectsWithTag("Potato");
            WallNavMesh.BuildNavMesh();
            TimeUntilScan = 1f;
        }

        for (int i = 0; i < Potatoes.Length; i++)
        {
            if (Potatoes[i].transform.position.x == bookshelvesPlaces[0].transform.position.x)
            {
                Movement = Random.Range(0f, 2f);
                transform.position -= new Vector3(Movement, 0f, 0f);
            }

            if (Potatoes[i].transform.position.x == bookshelvesPlaces[1].transform.position.x)
            {
                Movement = Random.Range(0f, 2f);
                transform.position -= new Vector3(Movement, 0f, 0f);
            }

            if (Potatoes[i].transform.position.x == bookshelvesPlaces[2].transform.position.x)
            {
                Movement = Random.Range(0f, 2f);
                transform.position += new Vector3(Movement, 0f, 0f);
            }

            if (Potatoes[i].transform.position.x == bookshelvesPlaces[3].transform.position.x)
            {
                Movement = Random.Range(0f, 2f);
                transform.position += new Vector3(Movement, 0f, 0f);
            }
        }

        if (Physics.Raycast(corrector, out correctorImpactReport))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (correctorImpactReport.collider == gameObject.GetComponent<Collider>())
                {
                    transform.position = new Vector3(0f, 4f, -8f);
                }
            }
        }
    }
}