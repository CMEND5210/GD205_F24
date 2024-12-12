using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookDisplayHard : MonoBehaviour
{
    GameObject[] Potatoes;

    Transform waitPlace;

    float TimeUntilScan = 1f;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        waitPlace = GameObject.FindGameObjectWithTag("WaitPlace").transform;
    }

    // Update is called once per frame
    void Update()
    {
        TimeUntilScan -= Time.deltaTime;
        if (TimeUntilScan <= 0)
        {
            Potatoes = GameObject.FindGameObjectsWithTag("Potato");
            TimeUntilScan = 1f;
        }

        for (int i = 0; i < Potatoes.Length; i++)
        {
            if (Potatoes[i].transform.position.x == waitPlace.transform.position.x)
            {
                text.text = Potatoes[i].GetComponent<PotatoMovementHard>().WantedBook.ToString();
            }

            else
            {
                text.text = ("");
            }
        }
    }
}