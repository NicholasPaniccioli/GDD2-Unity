﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprigMove : MonoBehaviour
{
    public static Vector2 currentPos;
    public static Vector2 forwardVec;
    //static GameObject gridMan;
    static GridManager gridScript;
    Tile[,] grid;

    // Start is called before the first frame update
    void Start()
    {
        gridScript = GameObject.Find("Grid Manager").GetComponent<GridManager>();
        grid = gridScript.Grid;
        currentPos = new Vector2(0, 0);
        forwardVec = new Vector2(0, -1);
        transform.position = new Vector3(currentPos.x, currentPos.y, 0);
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
        currentPos = gameObject.transform.position;
    }

    /// <summary>
    /// Moves the GameObject 1 tile on the grid
    /// </summary>
    private void Move()
    {
        // left
        if (Input.GetKeyDown(KeyCode.A))
        {
            // if the player isnt facing the direction they are going to move
            if (forwardVec != new Vector2(-1,0))
            {
                forwardVec = new Vector2(-1, 0);
                transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            // move the player
            else
            {
                if (currentPos.x > -10)
                {
                    if(true)
                    {
                        currentPos += forwardVec;
                        transform.position = new Vector3(currentPos.x, currentPos.y, 0);
                    }             
                }
            }
        }
        // right
        if (Input.GetKeyDown(KeyCode.D))
        {
            // if the player isnt facing the direction they are going to move
            if (forwardVec != new Vector2(1, 0))
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
        if (Input.GetKeyDown(KeyCode.W))
        {
            // if the player isnt facing the direction they are going to move
            if (forwardVec != new Vector2(0, 1))
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
        if (Input.GetKeyDown(KeyCode.S))
        {
            // if the player isnt facing the direction they are going to move
            if (forwardVec != new Vector2(0, -1))
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
