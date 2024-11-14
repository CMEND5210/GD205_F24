using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    Rigidbody rb;
    public Transform rascal;

    public float forceMultiplier = 15f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 rascalOffset = rascal.position - transform.position;
        Vector3 rascalDirection = Vector3.Normalize(rascalOffset);

        rb.AddForce(rascalDirection * forceMultiplier);
    }
}
