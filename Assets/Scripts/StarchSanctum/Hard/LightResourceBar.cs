using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightResourceBar : MonoBehaviour
{
    public float CurrentLightBar;
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
            CurrentLightBar = 50f + (5.556f * Wall.transform.position.x);
            UpdateBar();
    }

    void UpdateBar()
    {
        float FillAmount = (float)CurrentLightBar / MaximumBarAmount;
        bar.fillAmount = FillAmount;
    }
}
