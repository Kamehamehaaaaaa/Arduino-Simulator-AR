using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SensorsMenu : MonoBehaviour
{
    public void PlayTemp()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayUltrasonic()
    {
        SceneManager.LoadScene(3);
    }

    public void PlaySpeed()
    {
        SceneManager.LoadScene(4);
    }

    public void BackScene()
    {
        SceneManager.LoadScene(0);
    }
}
