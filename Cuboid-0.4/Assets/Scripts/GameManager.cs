using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleateLevel()
    {
        Debug.Log("Level Won");
        completeLevelUI.SetActive(true);


    }



    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);

            
        }

    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Spawner.timer = 0f;
        coin.numOfCoins = 0;
    }

    public void RestartButton()
    {
        // float restDelay = 1f;
        //gameHasEnded = true;
        PauseMenu.GameisPause = false;

        Debug.Log("Press Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Spawner.timer = 0f;
        coin.numOfCoins = 0;
        Time.timeScale = 1f;

        //Invoke("StartAfterRestar", restDelay);
    }

    //public void StartAfterRestart()
    //{

    //    Time.timeScale = 1f;
    //}



    public void BackToMainMenu()
    {

        SceneManager.LoadScene("Menu");


    }

}