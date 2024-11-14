using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpticBlast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit laserImpactReport = new RaycastHit();

        if (Physics.Raycast(laser, out laserImpactReport))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Destroy(laserImpactReport.collider.gameObject);
            }

            if (Input.GetKey(KeyCode.Mouse1))
            {
                laserImpactReport.rigidbody.AddExplosionForce(25f, laserImpactReport.point, 15f, 5f);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Instantiate(laserImpactReport.collider.gameObject);
            }
        }
    }
}
