using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessResourceHard : MonoBehaviour
{
    float TimeUntilScan = 1f;
    float ActivationTime;
    float CurrentHappiness = 100f;
    int MaximumHappiness = 100;
    GameObject[] Potatoes;
    [SerializeField]
    GameObject Potion;

    public Image bar;

    // Start is called before the first frame update
    void Start()
    {
        ActivationTime = 0f;
        Potatoes = GameObject.FindGameObjectsWithTag("Potato");
        UpdateBar();
    }

    // Update is called once per frame
    void Update()
    {
        Ray activator = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit activatorImpactReport = new RaycastHit();
        TimeUntilScan -= Time.deltaTime;
        if (TimeUntilScan <= 0)
        {
            Potatoes = GameObject.FindGameObjectsWithTag("Potato");
            TimeUntilScan = 1f;
        }
        
        if (Potatoes.Length > 0)
        {
            CurrentHappiness -= 0.005f;
            UpdateBar();
        }
        if (Physics.Raycast(activator, out activatorImpactReport))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (activatorImpactReport.collider.tag == "Potion" && ActivationTime == 0f)
                {
                    CurrentHappiness += 30f;
                    UpdateBar();
                    ActivationTime = 60f;
                }
            }
        }
        if (CurrentHappiness > 100f)
        {
            CurrentHappiness = 100f;
        }

        if (ActivationTime != 0f)
        {
            ActivationTime -= Time.deltaTime;
        }

        if (ActivationTime < 0f)
        {
            ActivationTime = 0f;
        }
    }
    
    void UpdateBar()
    {
        float FillAmount = (float)CurrentHappiness / MaximumHappiness;
        bar.fillAmount = FillAmount;
    }
}
