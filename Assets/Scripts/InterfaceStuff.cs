using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceStuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GamePause()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }

        else if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
    }
}
