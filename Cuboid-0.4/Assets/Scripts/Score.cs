using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public static bool pause;
    public Text scoreCoins;

    string m_MyEndlessSceen = "Level.endless";
    string m_CurrentSceen;

    float scoreMultiplier = 10.1f;
    float scoreForEndless;

    private void Start()
    {
        scoreText.text = "0";
        
        // m_Scene = SceneManager.GetActiveScene(); // check the active Sceen/Level 

        m_CurrentSceen = SceneManager.GetActiveScene().name;
       // Debug.Log(m_CurrentSceen);

        
    }

    // Update is called once per frame
    void Update () {
        //  Debug.Log(player.position.z);

        if (m_CurrentSceen != m_MyEndlessSceen)  // score: if is not the endless scene 
        {
            scoreText.text =player.position.z.ToString("0");

        }
        else
        {
            scoreForEndless = scoreMultiplier * Spawner.timer;
            scoreText.text = scoreForEndless.ToString("0.0");


            if (coin.numOfCoins == 0) //Show Coins 
            {
                scoreCoins.text = String.Concat(coin.numOfCoins.ToString(), " Coins");
            }
            else if (coin.numOfCoins == 1)
            {
                scoreCoins.text = String.Concat(coin.numOfCoins.ToString(), " Coin");
            }
            else
            {
                scoreCoins.text = String.Concat(coin.numOfCoins.ToString(), " Coins");
            }

            

        }
            //scoreText.text= player.position.z.ToString("0");




        //if (PauseMenu)
        //{


        //}

	}
}
