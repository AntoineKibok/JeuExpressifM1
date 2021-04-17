using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenusManager : MonoBehaviour
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
        levels.SetActive(false);
        credits.SetActive(false);
        main.SetActive(true);
    }

    public void goCredit()
    {
        main.SetActive(false);
        levels.SetActive(false);
        credits.SetActive(true);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
