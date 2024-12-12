using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookResourceBar : MonoBehaviour
{
    float TimeUntilScan = 1f;

    [SerializeField]
    int CurrentBookAmount = 10;

    int MaximumBookAmount = 10;
    GameObject[] Potatoes;
    Transform exitPlace;

    public Image bar;

    // Start is called before the first frame update
    void Start()
    {
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        exitPlace = GameObject.FindGameObjectWithTag("ExitPlace").transform;
        UpdateBar();
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
            if (Potatoes[i].transform.position.x == exitPlace.transform.position.x && Potatoes[i].transform.position.z == exitPlace.transform.position.z && Potatoes[i].GetComponent<Renderer>().material.color == Potatoes[i].GetComponent<PotatoMovement>().AngryColor)
            {
                CurrentBookAmount -= 1;
                Destroy(Potatoes[i]);
                UpdateBar();
            }
        }
    }

    void UpdateBar()
    {
        float FillAmount = (float)CurrentBookAmount / MaximumBookAmount;
        bar.fillAmount = FillAmount;
    }
}
