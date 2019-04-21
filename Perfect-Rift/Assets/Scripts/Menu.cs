using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject Rules;
    public GameObject Menus;
    public GameObject Credits;
    public GameObject LevelSelect;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void Level1()
    {
        SceneManager.LoadScene(01);
    }

    public void Level2()
    {
        SceneManager.LoadScene(02);
    }

    public void Level3()
    {
        SceneManager.LoadScene(03);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(00);
    }

    public void Retry()
    {
        SceneManager.LoadScene(01);
    }

    public void Rule ()
    {
        Menus.SetActive(false);
        Rules.SetActive(true);
    }

    public void Back()
    {
        Rules.SetActive(false);
        Menus.SetActive(true);
    }

    public void Cred()
    {
        Menus.SetActive(false);
        Credits.SetActive(true);

    }

    public void Back2()
    {
        Credits.SetActive(false);
        Menus.SetActive(true);
    }

    public void LevelSel()
    {
        Menus.SetActive(false);
        LevelSelect.SetActive(true);
    }

    public void Back3()
    {
        LevelSelect.SetActive(false);
        Menus.SetActive(true);
    }


    public void Quit()
    {
        Application.Quit();
    }

}
