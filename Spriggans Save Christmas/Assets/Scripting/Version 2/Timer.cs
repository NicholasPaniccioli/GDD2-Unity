﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft = 120;  // number of time left in seconds
    public Text countDown;
    public static bool winGame;
    public static bool loseGame;
    public GameObject gameOverScreen;
    private string levelName;   // name of the scene

    // Start is called before the first frame update
    void Start()
    {
        //Start thread for Timer
        StartCoroutine("LoseTime");
        loseGame = false;   // start lose game condition as false
        winGame = false;    // start the win game condition as false
        Time.timeScale = 1;
        levelName = SceneManager.GetActiveScene().name; // get the name of the currently active scene
    }

    // Update is called once per frame
    void Update()
    {
        countDown.text = ("" + timeLeft);   // update the timer text
    }
    /// <summary>
    ///Method to adjust the timer
    /// </summary>
    /// <returns></returns>
    IEnumerator LoseTime()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            if (winGame)    // if the player wins
            {
                GameObject.Find("SuccessSound").GetComponent<AudioSource>().Play();
                //transition to win screen
                GameOver(); // display Game Over screen
                Debug.Log("You win!");  // output a message to the console indicating success

            }
            else
            {
                timeLeft--; // decrease the amount of time left
            }
        }
        //Transition to loss screen
        loseGame = true;    // set lose game condition to true
        GameObject.Find("FailSound").GetComponent<AudioSource>().Play();
        GameOver(); // display the game over screen
        Debug.Log("You lose! Christmas is ruined!");    // output a message to the console indicating loss
    }

    void GameOver()
    {
        gameOverScreen.SetActive(true); // bring up the game over screen

        if (loseGame)   // if the player loses
        {
            gameOverScreen.GetComponentInChildren<Text>().text = "You lose! Christmas is ruined!";  // display a lose message
        }
        if(winGame) // if the player wins
        {
            gameOverScreen.GetComponentInChildren<Text>().text = "You win!";    // display a win message

        }

        Time.timeScale = 0f;    // pause the game so that the player can't move
        //paused = true;
    }

    // Reload the current scene
    public void Retry()
    {
        SceneManager.LoadScene(levelName);  // reload the current scene
    }
}
