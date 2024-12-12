using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorRotationLeft : MonoBehaviour
{
    public float TimeUntilRotate = 2f;
    float TimeUntilSceneChange = 6f;
    public string Level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeUntilRotate -= Time.deltaTime;
        TimeUntilSceneChange -= Time.deltaTime;
        if (TimeUntilRotate <= 0)
        {
            transform.rotation = Quaternion.AngleAxis(90f, Vector3.up);
            transform.position = new Vector3(-1.2f, 1.4f, -5f);
        }

        if (TimeUntilSceneChange <= 0)
        {
            SceneManager.LoadScene(Level);
        }
    }
}
