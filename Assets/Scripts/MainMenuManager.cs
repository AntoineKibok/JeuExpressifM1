using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject back, main, levels, credits;

    // Start is called before the first frame update
    void Start()
    {
        back.SetActive(true);
        goMain();
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void goMain()
    {
        Debug.Log("Tqt bg");
        levels.SetActive(false);
        credits.SetActive(false);
        main.SetActive(true);
    }

    public void goCredit()
    {
        Debug.Log("Clic salope");
        main.SetActive(false);
        levels.SetActive(false);
        credits.SetActive(true);
        Debug.Log("Clic salope²");

    }

    public void goLevels()
    {
        main.SetActive(false);
        credits.SetActive(false);
        levels.SetActive(true);
    }

    public void chooseChapter(string name)
    {
        SceneManager.LoadScene("Scenes/" + name);
    }

}
