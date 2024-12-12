using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneSpawning : MonoBehaviour
{
    float PotatoSpawnTime = 2f;
    int LuckySpawner;
    GameObject[] Spawners;

    public GameObject Potato;

    // Start is called before the first frame update
    void Start()
    {
        Spawners = GameObject.FindGameObjectsWithTag("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        PotatoSpawnTime -= Time.deltaTime;
        if (PotatoSpawnTime <= 0)
        {
            SetLuckySpawner();

            Instantiate(Potato, Spawners[LuckySpawner].transform.position, Quaternion.identity);
            PotatoSpawnTime = 0.1f;
        }
    }

    void SetLuckySpawner()
    {
        LuckySpawner = Random.Range(0, Spawners.Length);
    }
}
