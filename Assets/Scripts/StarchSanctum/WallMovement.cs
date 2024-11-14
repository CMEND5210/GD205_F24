using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Potato;
    public Transform[] bookshelvesPlaces;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < bookshelvesPlaces.Length; i++)
        {
            if (Potato.transform.position.x == bookshelvesPlaces[i].transform.position.x)
            {
                if (bookshelvesPlaces[i] == bookshelvesPlaces[0])
                {
                    transform.position -= new Vector3(0.5f, 0f, 0f);
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[1])
                {
                    transform.position -= new Vector3(0.5f, 0f, 0f);
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[2])
                {
                    transform.position += new Vector3(0.5f, 0f, 0f);
                }

                if (bookshelvesPlaces[i] == bookshelvesPlaces[3])
                {
                    transform.position += new Vector3(0.5f, 0f, 0f);
                }
            }
        }
    }
}
