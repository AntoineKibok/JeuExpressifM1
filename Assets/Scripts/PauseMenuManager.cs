using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject toggleMenu;
    public GameObject menu;
    public Flowchart flowchart;

    void Start()
    {
        toggleMenu.SetActive(true);
        menu.SetActive(false);
    }
    public void Pause()
    {
        Time.timeScale = 0;
        toggleMenu.SetActive(false);
        menu.SetActive(true);
    }

    public void UnPause()
    {
        Time.timeScale = 1;
        toggleMenu.SetActive(true);
        menu.SetActive(false);
    }

    public void Restart()
    {
        UnPause();
        flowchart.ExecuteBlock("Relancer");

    }

    public void GoToMainMenu()
    {
        UnPause();
        flowchart.ExecuteBlock("Retour menu");
    }

    public void Quit()
    {
        UnPause();
        Application.Quit();
    }

}
