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
    public AudioSource sonClic;


    void Start()
    {
        toggleMenu.SetActive(true);
        menu.SetActive(false);
    }
    public void Pause()
    {
        sonClic.Play();
        Time.timeScale = 0;
        toggleMenu.SetActive(false);
        menu.SetActive(true);
    }

    public void UnPause()
    {
        sonClic.Play();
        Time.timeScale = 1;
        toggleMenu.SetActive(true);
        menu.SetActive(false);
    }

    public void Restart()
    {
        sonClic.Play();
        UnPause();
        flowchart.ExecuteBlock("Relancer");

    }

    public void GoToMainMenu()
    {
        sonClic.Play();
        UnPause();
        flowchart.ExecuteBlock("Retour menu");
    }

    public void Quit()
    {
        sonClic.Play();
        UnPause();
        Application.Quit();
    }

}
