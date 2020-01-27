using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;


    private void Start()
    {


        Resume();

        // SceneManager.LoadScene(0);


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
          PauseMenuUI.SetActive(false);
        //PauseMenuUI.
          Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Resumed game");
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        GameIsPaused = true;
        Debug.Log("Paused game");
    }

    public void BackToMenu()
    {
        Debug.Log("Going back to main menu...");
        SceneManager.LoadScene(0);

    }

}
