using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SillyNav : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent MokapAgent;

    void Start()
    {
        MokapAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetInteger("Walk", 0);

        Ray pointer = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit pointerImpactReport = new RaycastHit();

        if (Physics.Raycast(pointer, out pointerImpactReport))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                MokapAgent.SetDestination(pointerImpactReport.point);
                if (gameObject.transform.position != pointerImpactReport.point)
                {
                    GetComponent<Animator>().SetInteger("Walk", 1);
                }
            }
        }
    }
}
