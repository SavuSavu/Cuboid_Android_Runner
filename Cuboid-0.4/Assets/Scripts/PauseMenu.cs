using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public static bool GameisPause = false;
    public GameObject pauseMenuUI;

    public GameObject myButton;
    


	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }


	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPause = false;

    }


    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPause = true;


        myButton = GameObject.Find("BtnPause");
        //myButton.SetActive = false;


    }

    public void LoadMenu()
    {
        Debug.Log("Load Menu...");
        //SceneManager.LoadScene("Menu");    // change this with the menu scene 
    }

    public void ExitGame()
    {

        Debug.Log("Exit the game...");
        Application.Quit();
        
    }


}
