using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPaused : MonoBehaviour
{
    public GameObject menuPaused;
    [SerializeField] KeyCode keyMenuPaused;
    bool isMenuPaused = false;

    private void Start()
    {
        menuPaused.SetActive(false);
    }

    private void Update()
    {
        ActiveMenu();
    }
    void ActiveMenu()
    {
        if (Input.GetKeyDown(keyMenuPaused))
        {
            isMenuPaused = !isMenuPaused;
        }

        if (isMenuPaused)
        {
            menuPaused.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            menuPaused.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void MenuPausedContinue()
    {
        isMenuPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
