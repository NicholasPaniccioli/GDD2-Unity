﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenemanage : MonoBehaviour {
    //  Loads the main game scene
    public void LoadGame() {

        Time.timeScale = 1f;
        PauseMenu.paused = false;
        SceneManager.LoadScene("FirstLevel");
    }

    public void QuitGame() {
        Debug.Log("Game Closing!");
        Application.Quit();
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Pause");
    }
}
