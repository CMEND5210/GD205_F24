using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwap : MonoBehaviour
{

    public GameObject player;
    public Material[] checking;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = checking[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == player.transform.position.x && transform.position.z == player.transform.position.z)
        {
            rend.sharedMaterial = checking[1];
        }
    }
}
