using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoSpawnHard : MonoBehaviour
{
    float MinimumRushTime = 15f;
    float MaximumRushTime = 25f;
    float TimeUntilPotatoRush;

    public GameObject Potato;

    // Start is called before the first frame update
    void Awake()
    {
        SetTimeUntilPotatoRush();
    }

    // Update is called once per frame
    void Update()
    {
        TimeUntilPotatoRush -= Time.deltaTime;

        if (TimeUntilPotatoRush <= 0)
        {
            Instantiate(Potato, transform.position, Quaternion.identity);
            SetTimeUntilPotatoRush();
        }
    }

    void SetTimeUntilPotatoRush()
    {
        TimeUntilPotatoRush = Random.Range(MinimumRushTime, MaximumRushTime);
    }
}