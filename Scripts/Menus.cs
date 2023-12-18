using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    [Header("All Menu's")]
    public GameObject pauseMenuUI;
    public GameObject EndGameMenuUI;
    public GameObject ObjectiveMenuUI;

    public static bool GameIsStopped = false;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsStopped)
            {
                resume();
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Pause();
                Cursor.lockState = CursorLockMode.None;
            }
        }
        else if(Input.GetKeyDown("m"))
        {
            if(GameIsStopped)
            {
                removeObjective();
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                showObjective();
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    public void showObjective()
    {
        ObjectiveMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsStopped = true;
    }

    public void removeObjective()
    {
        ObjectiveMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        GameIsStopped = false;
    }

    public void resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        GameIsStopped = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsStopped = true;
    }

}
