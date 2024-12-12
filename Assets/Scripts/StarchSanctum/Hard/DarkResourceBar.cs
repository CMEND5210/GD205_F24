using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkResourceBar : MonoBehaviour
{
    public float CurrentDarkBar;
    int MaximumBarAmount = 100;

    public Image bar;
    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        UpdateBar();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentDarkBar = 50f + (5.556f * -Wall.transform.position.x);
        UpdateBar();
    }

    void UpdateBar()
    {
        float FillAmount = (float)CurrentDarkBar / MaximumBarAmount;
        bar.fillAmount = FillAmount;
    }
}