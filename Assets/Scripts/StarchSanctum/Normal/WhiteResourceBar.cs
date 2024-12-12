using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteResourceBar : MonoBehaviour
{
   public float CurrentWhiteBar = 50f;
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
        if (Wall.transform.position.x <= -9)
        {
            CurrentWhiteBar = 0f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -8.5 && Wall.transform.position.x <= -8)
        {
            CurrentWhiteBar = 5.552f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -7.5 && Wall.transform.position.x <= -7)
        {
            CurrentWhiteBar = 11.108f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -6.5 && Wall.transform.position.x <= -6)
        {
            CurrentWhiteBar = 16.664f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -5.5 && Wall.transform.position.x <= -5)
        {
            CurrentWhiteBar = 22.22f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -4.5 && Wall.transform.position.x <= -4)
        {
            CurrentWhiteBar = 27.776f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -3.5 && Wall.transform.position.x <= -3)
        {
            CurrentWhiteBar = 33.332f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -2.5 && Wall.transform.position.x <= -2)
        {
            CurrentWhiteBar = 38.888f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -1.5 && Wall.transform.position.x <= -1)
        {
            CurrentWhiteBar = 44.444f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -0.5 && Wall.transform.position.x <= 0.5)
        {
            CurrentWhiteBar = 50f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 1 && Wall.transform.position.x <= 1.5)
        {
            CurrentWhiteBar = 55.556f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 2 && Wall.transform.position.x <= 2.5)
        {
            CurrentWhiteBar = 61.112f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 3 && Wall.transform.position.x <= 3.5)
        {
            CurrentWhiteBar = 66.668f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 4 && Wall.transform.position.x <= 4.5)
        {
            CurrentWhiteBar = 72.224f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 5 && Wall.transform.position.x <= 5.5)
        {
            CurrentWhiteBar = 77.78f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 6 && Wall.transform.position.x <= 6.5)
        {
            CurrentWhiteBar = 83.336f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 7 && Wall.transform.position.x <= 7.5)
        {
            CurrentWhiteBar = 88.892f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 8 && Wall.transform.position.x <= 8.5)
        {
            CurrentWhiteBar = 94.448f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 9)
        {
            CurrentWhiteBar = 100f;
            UpdateBar();
        }
    }

    void UpdateBar()
    {
        float FillAmount = (float)CurrentWhiteBar / MaximumBarAmount;
        bar.fillAmount = FillAmount;
    }
}
