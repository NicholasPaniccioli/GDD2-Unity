using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Started by Kyle Mulvey
// Beginning to implement the generation of the grid.

public class SprigMove : MonoBehaviour
{
    GameObject gridMan;
    Vector2 currentPos;
    Vector2 forwardVec;

    // Start is called before the first frame update
    void Start()
    {
        gridMan = GameObject.Find("GridManager");
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
                currentPos += forwardVec;
                transform.position = new Vector3(currentPos.x, currentPos.y, 0);
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
                currentPos += forwardVec;
                transform.position = new Vector3(currentPos.x, currentPos.y, 0);
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
                currentPos += forwardVec;
                transform.position = new Vector3(currentPos.x, currentPos.y, 0);
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
                currentPos += forwardVec;
                transform.position = new Vector3(currentPos.x, currentPos.y, 0);
            }
        }
    }
}
