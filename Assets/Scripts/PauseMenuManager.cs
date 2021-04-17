using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject toggleMenu;
    public GameObject menu;

    void Start()
    {
        toggleMenu.SetActive(true);
        menu.SetActive(false);
    }
    public void Pause()
    {
        toggleMenu.SetActive(false);
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        toggleMenu.SetActive(true);
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        UnPause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        Destroy(GameObject.Find("FungusManager"));
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
