using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{

    public GameObject playButton;


    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Play()
    {
        SceneManager.LoadSceneAsync(1);
    }
    
    public void Ballroom()
    {
        SceneManager.LoadSceneAsync(2);
    }
}