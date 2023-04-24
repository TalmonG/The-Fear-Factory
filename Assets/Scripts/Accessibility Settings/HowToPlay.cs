using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    [SerializeField] GameObject wPanel;
    [SerializeField] GameObject aPanel;
    [SerializeField] GameObject sPanel;
    [SerializeField] GameObject dPanel;
    [SerializeField] GameObject ePanel;
    [SerializeField] GameObject whatgameispanel;

    void Start()
    {
        wPanel.SetActive(true);
        aPanel.SetActive(false);
        sPanel.SetActive(false);
        ePanel.SetActive(false);
        whatgameispanel.SetActive(false);
    }

    public void loadwpanel()
    {
        wPanel.SetActive(true);
        aPanel.SetActive(false);
        sPanel.SetActive(false);
        ePanel.SetActive(false);
        whatgameispanel.SetActive(false);
    }

    public void loadapanel()
    {
        wPanel.SetActive(false);
        aPanel.SetActive(true);
        sPanel.SetActive(false);
        ePanel.SetActive(false);
        whatgameispanel.SetActive(false);
    }

    public void loadspanel()
    {
        wPanel.SetActive(false);
        aPanel.SetActive(false);
        sPanel.SetActive(true);
        ePanel.SetActive(false);
        whatgameispanel.SetActive(false);
    }

    public void loadepanel()
    {
        wPanel.SetActive(false);
        aPanel.SetActive(false);
        sPanel.SetActive(false);
        ePanel.SetActive(true);
        whatgameispanel.SetActive(false);
    }

    public void loadwhatgameispanel()
    {
        wPanel.SetActive(false);
        aPanel.SetActive(false);
        sPanel.SetActive(false);
        ePanel.SetActive(false);
        whatgameispanel.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}