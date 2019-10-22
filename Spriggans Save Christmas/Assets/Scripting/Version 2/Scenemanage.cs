using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenemanage : MonoBehaviour {
    //  Loads the main game scene
    public void LoadGame() {
        SceneManager.LoadScene("TheCOolOurScene");
    }

    public void QuitGame() {
        Debug.Log("Game Closing!");
        Application.Quit();
    }
}
