using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PotatoBookDisplay : MonoBehaviour
{
    [SerializeField]
    GameObject[] Potatoes;
    
    Transform waitPlace;

    float TimeUntilScan = 1f;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
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
            if (Potatoes[i].GetComponent<Renderer>().material.color == Color.yellow && Potatoes[i].transform.position.x == waitPlace.transform.position.x)
            {
                text.text = Potatoes[i].GetComponent<PotatoMovement>().WantedBook.ToString();
            }

            else
            {
                text.text = ("");
            }
        }
    }
}
