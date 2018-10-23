using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {

        SceneManager.LoadScene("LEPROCORN_THE_GOLDEN_SHOWER");

    }

    public void QuitGame()
    {

        Debug.Log("this works");
        Application.Quit();

    }

}
