//This script is borrowed from MoreBBlakeyyy on YouTube.
//https://www.youtube.com/shorts/YVATrLTZZTk
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//We call all the libraries we are using here.
//We are using the default Unity libraries, as well as UnityEngine.SceneManagement.

public class ButtonSceneSwitch : MonoBehaviour
{
    public string LevelSelect;
    //We create a public string variable, named LevelSelect.
    //That will be the name of the scene that we want to switch to.
    public void OnClick()
        //We create a function named OnClick.
        //It is public so the button's OnClick() function can use it.
    {
        SceneManager.LoadScene(LevelSelect);
        //We use the SceneManger to load the scene with the LevelSelect variable.
        //Or we load the scene we want using the scene's name.
    }
}
