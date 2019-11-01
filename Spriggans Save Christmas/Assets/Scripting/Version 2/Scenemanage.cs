using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenemanage : MonoBehaviour {

    string sceneName;
    //  Loads the main game scene
    public void LoadGame() {

        Time.timeScale = 1f;
        PauseMenu.paused = false;
        SceneManager.LoadScene("FirstLevel");   // load the First Level scene
    }

    public void QuitGame() {
        Debug.Log("Game Closing!");
        Application.Quit(); // close the game (only works when built)
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions"); // load the Instructions scene
    }

    private void Start()
    {
        sceneName = SceneManager.GetActiveScene().name; // get the name of the current scene
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))    // if the player presses the escape key
        {
            if(sceneName == "Instructions") // if the scene is the Instructions scene
            {
                Debug.Log("Loading Start Screen");  // output message the console
                SceneManager.LoadScene("StartScreen");  // load the Start Screen scene
            }
        }
    }
}
