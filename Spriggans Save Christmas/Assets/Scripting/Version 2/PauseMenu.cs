using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false; //Is the game paused?
    public GameObject pauseUI;


    // Update is called once per frame
    void Update()
    {
        //checks if player presses p to pause game
        if (Input.GetKeyDown("p"))
        {
            if (paused == true)
            {
                //If already paused, resumes the game
                ResumeGame();
            }
            else
            {
                //If not paused, pauses the game
                PauseGame();
            }
        }
    }

    //Method to resume the game and allow things to move
    public void ResumeGame()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    //Pauses the game and brings up the UI
    void PauseGame()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    //Goes to a scene/panel with the instructions in it
    //NEEDS CODE for the instructions
    public void LoadInstructions()
    {
        Debug.Log("Instructions");
    }

    //When pressed goes back to the menu of the game
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScreen");
        paused = false;
    }

    //When pressed closes the application
    public void QuitGame()
    {
        Debug.Log("Quiting game!");
        Application.Quit();
    }


    //when pressed the player will skip the tutorial and go to the actual game.
    public void Skip()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TheCOolOurScene");
        paused = false;
    }
}
