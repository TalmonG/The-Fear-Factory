using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject progresslost;
    public GameObject settingsMenu;

    public bool isPaused;


    void Update()
    {
        
    }

    void Start()
    {
        pauseMenu.SetActive(false);
        progresslost.SetActive(false);
        settingsMenu.SetActive(false);
        isPaused = true;
    }

    public void Pause()
    {
        isPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pauseMenu.SetActive(true);
        settingsMenu.SetActive(false);
        progresslost.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        isPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        progresslost.SetActive(false);
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        pauseMenu.SetActive(false);
        progresslost.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void BackToPause()
    {
        Pause();

    }

    public void SettingsMenu()
    {
        pauseMenu.SetActive(false);
        progresslost.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void YesQuit()
    {
        Time.timeScale = 1f;
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<AudioManager>().Stop("Chase");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);    
        FindObjectOfType<AudioManager>().Stop("Chase");

    }

}
