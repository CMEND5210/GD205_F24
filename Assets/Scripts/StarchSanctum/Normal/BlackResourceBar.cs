using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackResourceBar : MonoBehaviour
{
    public float CurrentBlackBar = 50f;
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
            CurrentBlackBar = 100f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -8.5 && Wall.transform.position.x <= -8)
        {
            CurrentBlackBar = 94.448f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -7.5 && Wall.transform.position.x <= -7)
        {
            CurrentBlackBar = 88.892f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -6.5 && Wall.transform.position.x <= -6)
        {
            CurrentBlackBar = 83.336f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -5.5 && Wall.transform.position.x <= -5)
        {
            CurrentBlackBar = 77.78f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -4.5 && Wall.transform.position.x <= -4)
        {
            CurrentBlackBar = 72.224f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -3.5 && Wall.transform.position.x <= -3)
        {
            CurrentBlackBar = 66.668f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -2.5 && Wall.transform.position.x <= -2)
        {
            CurrentBlackBar = 61.112f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -1.5 && Wall.transform.position.x <= -1)
        {
            CurrentBlackBar = 55.556f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= -0.5 && Wall.transform.position.x <= 0.5)
        {
            CurrentBlackBar = 50f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 1 && Wall.transform.position.x <= 1.5)
        {
            CurrentBlackBar = 44.444f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 2 && Wall.transform.position.x <= 2.5)
        {
            CurrentBlackBar = 38.888f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 3 && Wall.transform.position.x <= 3.5)
        {
            CurrentBlackBar = 33.332f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 4 && Wall.transform.position.x <= 4.5)
        {
            CurrentBlackBar = 27.776f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 5 && Wall.transform.position.x <= 5.5)
        {
            CurrentBlackBar = 22.22f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 6 && Wall.transform.position.x <= 6.5)
        {
            CurrentBlackBar = 16.664f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 7 && Wall.transform.position.x <= 7.5)
        {
            CurrentBlackBar = 11.108f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 8 && Wall.transform.position.x <= 8.5)
        {
            CurrentBlackBar = 5.552f;
            UpdateBar();
        }

        if (Wall.transform.position.x >= 9)
        {
            CurrentBlackBar = 0f;
            UpdateBar();
        }
    }

    void UpdateBar()
    {
        float FillAmount = (float)CurrentBlackBar / MaximumBarAmount;
        bar.fillAmount = FillAmount;
    }
}
