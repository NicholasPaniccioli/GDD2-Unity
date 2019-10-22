using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager2 : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject[] interactObjects;
    private GameObject[,] grid;
    private Vector3 playerFacing; //vector for interaction
    public Sprite spriteForward;
    public Sprite spriteBackward;
    public Sprite spriteRight;
    public Sprite spriteLeft;

    // Start is called before the first frame update
    void Start()
    {
        grid = new GameObject[20,10];
        interactObjects = GameObject.FindGameObjectsWithTag("Interactable");
        for (int x = 0; x < interactObjects.Length; x++)
        {
            //occupies the grid with objects
            grid[(int)interactObjects[x].transform.position.x,(int)interactObjects[x].transform.position.y] = interactObjects[x];
        }
        grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
        playerFacing = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.paused == false)
        {
            #region Player Movement
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))   // if the user presses 'W' or the Up Arrow
            {
                if (playerObject.transform.position.y != grid.GetLength(1) - 1 && grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y + 1] == null)
                {
                    grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = null;
                    Vector3 newVector = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + 1, playerObject.transform.position.z);
                    //  TODO: non-teleportive movement
                    playerObject.transform.position = newVector;
                    grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
                }
                playerObject.GetComponent<SpriteRenderer>().sprite = spriteBackward;
                playerFacing = Vector3.up;
            }
            else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)))    // if the user presses 'S' or the Down Arrow
            {
                if (playerObject.transform.position.y != 0 && grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y - 1] == null)
                {
                    grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = null;
                    Vector3 newVector = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y - 1, playerObject.transform.position.z);
                    playerObject.transform.position = newVector;
                    grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
                }
                playerObject.GetComponent<SpriteRenderer>().sprite = spriteForward;
                playerFacing = Vector3.down;
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))    // if the user presses 'A' or the Left Arrow
            {
                if (playerObject.transform.position.x != 0 && grid[(int)playerObject.transform.position.x - 1, (int)playerObject.transform.position.y] == null)
                {
                    grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = null;
                    Vector3 newVector = new Vector3(playerObject.transform.position.x - 1, playerObject.transform.position.y, playerObject.transform.position.z);
                    playerObject.transform.position = newVector;
                    grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
                }
                playerObject.GetComponent<SpriteRenderer>().sprite = spriteLeft;
                playerFacing = Vector3.left;
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))   // if the user presses 'D' or the Right Arrow
            {
                if (playerObject.transform.position.x != grid.GetLength(0) - 1 && grid[(int)playerObject.transform.position.x + 1, (int)playerObject.transform.position.y] == null)
                {
                    grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = null;
                    Vector3 newVector = new Vector3(playerObject.transform.position.x + 1, playerObject.transform.position.y, playerObject.transform.position.z);
                    playerObject.transform.position = newVector;
                    grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
                }
                playerObject.GetComponent<SpriteRenderer>().sprite = spriteRight;
                playerFacing = Vector3.right;
            }
            #endregion


            //check for interaction
            if (Input.GetKeyDown(KeyCode.E))
            {
                Vector3 interactTile = playerObject.transform.position + playerFacing;
                if (grid[(int)interactTile.x, (int)interactTile.y] != null)
                {
                    grid[(int)interactTile.x, (int)interactTile.y].GetComponent<Tile>().Interact(playerObject.GetComponent<Player>());
                }
            }
        }
    }
}
