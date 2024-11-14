using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFlip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetInteger("Walk", 0);
        GetComponent<Animator>().SetInteger("Turn", 0);

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Animator>().SetInteger("Walk", 1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetInteger("Turn", -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetInteger("Turn", 1);
        }
    }
}
