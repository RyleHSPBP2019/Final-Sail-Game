using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    public void toOptions()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void toCredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void toLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void toMenu()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1) // if the active scene is options...
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // switch to the menu scene
        }

        else if (SceneManager.GetActiveScene().buildIndex == 2) // if the active scene is credits...
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); // switch to the menu scene
        }

        else if (SceneManager.GetActiveScene().buildIndex == 3) // if the active scene in level1
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3); // switch to the menu scene
        }
    }


}
