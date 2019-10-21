using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprig_Move : MonoBehaviour
{
    public Vector3 currentPos; // current Position of the player
    public Vector3 forwardVec; // forward vector of the player 
    public Vector3 walkforce; // The force that affects the players walk

    // Start is called before the first frame update
    void Start()
    {
        currentPos = new Vector3(0, 0, 0); //Default starting position
        forwardVec = new Vector3(0, -1, 0); //The forward position at the start

        transform.position = new Vector3(currentPos.x, currentPos.y, 0); //sets the new set position for the player
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        currentPos = transform.position;
        //forwardVec = transform.position.y
    }

    /// <summary>
    /// Moves the GameObject 1 tile on the grid
    /// </summary>
    private void Move()
    {
        // left
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) // if the player presses 'A' or the Left Arrow
        {
            // if the player isnt facing the direction they are going to move
            if (forwardVec != new Vector3(-1, 0))
            {
                forwardVec = new Vector2(-1, 0);
                transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            // move the player
            else
            {
                if (currentPos.x > -10)
                {
                    if (true)
                    {
                        currentPos += forwardVec;
                        transform.position = new Vector3(currentPos.x, currentPos.y, 0);
                    }
                }
            }
        }
        // right
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))    // if the player presses 'D' or the Right Arrow
        {
            // if the player isnt facing the direction they are going to move
            if (forwardVec != new Vector3(1, 0))
            {
                forwardVec = new Vector2(1, 0);
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            // move the player
            else
            {
                if (currentPos.x < 10)
                {
                    currentPos += forwardVec;
                    transform.position = new Vector3(currentPos.x, currentPos.y, 0);
                }
            }
        }
        // up
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))   // if the player presses 'W' or the Up Arrow
        {
            // if the player isnt facing the direction they are going to move
            if (forwardVec != new Vector3(0, 1))
            {
                forwardVec = new Vector2(0, 1);
                transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            // move the player
            else
            {
                if (currentPos.y < 4)
                {
                    currentPos += forwardVec;
                    transform.position = new Vector3(currentPos.x, currentPos.y, 0);
                }
            }
        }
        // down
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) // if the player presses 'S' or the Down Arrow
        {
            // if the player isnt facing the direction they are going to move
            if (forwardVec != new Vector3(0, -1))
            {
                forwardVec = new Vector2(0, -1);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            // move the player
            else
            {
                if (currentPos.y > -4)
                {
                    currentPos += forwardVec;
                    transform.position = new Vector3(currentPos.x, currentPos.y, 0);
                }
            }
        }
    }
}
