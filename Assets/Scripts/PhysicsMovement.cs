using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0f, 0f, 1f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0f, 0f, -1f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-1f, 0f, 0f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(1f, 0f, 0f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(0f, -1f, 0f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.E))
        {
            rb.AddForce(0f, 1f, 0f, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision damageReport)
    {
        if (damageReport.gameObject.tag == "Terrain")
        {
            Destroy(gameObject);
        }

        if (damageReport.gameObject.tag == "Mother")
        {
            Destroy(gameObject);
        }

        if (damageReport.transform.localScale.magnitude > gameObject.transform.localScale.magnitude)
        {
            Destroy(gameObject);
        }

        if (damageReport.transform.localScale.magnitude <= gameObject.transform.localScale.magnitude)
        {
            Destroy(damageReport.gameObject);
            gameObject.transform.localScale += damageReport.transform.localScale;
        }
    }
}
