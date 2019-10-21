using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Kyle Mulvey
// This script should be attached to an empty object in the scene.
// When the user presses the escape key, the application will close.

public class Quit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))   // when the player presses the escape key
        {
            Application.Quit();                 // quit the application. Only works when game is built.
        }
    }
}
