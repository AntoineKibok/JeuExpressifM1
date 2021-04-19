using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject back, main, levels, credits;
    public AudioSource sonClic;

    // Start is called before the first frame update
    void Start()
    {
        back.SetActive(true);
        goMain();
    }

    public void Quit()
    {
        sonClic.Play();
        Application.Quit();
    }

    public void goMain()
    {
        sonClic.Play();
        levels.SetActive(false);
        credits.SetActive(false);
        main.SetActive(true);
    }

    public void goCredit()
    {
        sonClic.Play();
        main.SetActive(false);
        levels.SetActive(false);
        credits.SetActive(true);
    }

    public void goLevels()
    {
        sonClic.Play();
        main.SetActive(false);
        credits.SetActive(false);
        levels.SetActive(true);
    }

    public void chooseChapter(string name)
    {
        sonClic.Play();
        SceneManager.LoadScene("Scenes/" + name);
    }

}
