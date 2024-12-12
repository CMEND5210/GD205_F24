using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotation : MonoBehaviour
{
    public float Movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Movement, 0f, 0f);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "LeftWarp")
        {
            transform.position = new Vector3(12f, 4f, 0f);
        }

        if (col.tag == "RightWarp")
        {
            transform.position = new Vector3(-12f, 0f, 0f);
        }
    }
}
