using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessResourceBar : MonoBehaviour
{
    float TimeUntilScan = 1f;
    float CurrentHappiness = 100f;
    int MaximumHappiness = 100;
    GameObject[] Potatoes;
    Transform waitPlace;
    bool HealBar;

    public Image bar;

    // Start is called before the first frame update
    void Start()
    {
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        waitPlace = GameObject.FindGameObjectWithTag("WaitPlace").transform;
        UpdateBar();
        HealBar = true;
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

        if (HealBar == true)
        {
            CurrentHappiness += .05f;
            UpdateBar();
        }

        if (CurrentHappiness > 100f)
        {
            CurrentHappiness = 100f;
        }

        for (int i = 0; i < Potatoes.Length; i++)
        {
            if(Potatoes[i].transform.position.x == waitPlace.transform.position.x && Potatoes[i].transform.position.z == waitPlace.transform.position.z)
            {
                HealBar = false;
                CurrentHappiness -= .1f;
                UpdateBar();
            }

            else
            {
                HealBar = true;
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        for (int i = 0; i < Potatoes.Length; i++)
        {
            if (col.tag == "InteractionArea")
            {
                HealBar = false;
                CurrentHappiness -= .2f;
                UpdateBar();
            }
        }
    }

    void UpdateBar()
    {
        float FillAmount = (float)CurrentHappiness / MaximumHappiness;
        bar.fillAmount = FillAmount;
    }
}
