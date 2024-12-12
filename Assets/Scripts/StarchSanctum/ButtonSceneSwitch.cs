using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneSwitch : MonoBehaviour
{
    public string LevelSelect;
    public void OnClick()
    {
        SceneManager.LoadScene(LevelSelect);
    }
}
