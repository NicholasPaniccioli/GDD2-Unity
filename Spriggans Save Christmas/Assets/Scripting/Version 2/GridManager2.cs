using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager2 : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject[] interactObjects;
    private GameObject[,] grid;

    // Start is called before the first frame update
    void Start()
    {
        grid = new GameObject[25,10];
        //interactObjects = GameObject.FindGameObjectsWithTag("Object");
        interactObjects = new GameObject[0];
        for (int x = 0; x < interactObjects.Length; x++)
        {
            //occupies the grid with objects
            grid[(int)interactObjects[x].transform.position.x,(int)interactObjects[x].transform.position.y] = interactObjects[x];
        }
        grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject.transform.position.y != grid.GetLength(1)-1 && Input.GetKey(KeyCode.W))
        {
            if (grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y + 1] == null)
            {
                grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = null;
                Vector3 newVector = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y+1, playerObject.transform.position.z);
                playerObject.transform.position = newVector;
                grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
            }
        }
        else if (playerObject.transform.position.y != 0 && Input.GetKey(KeyCode.S))
        {
            if (grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y - 1] == null)
            {
                grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = null;
                Vector3 newVector = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y - 1, playerObject.transform.position.z);
                playerObject.transform.position = newVector;
                grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (playerObject.transform.position.x != 0 && grid[(int)playerObject.transform.position.x-1 , (int)playerObject.transform.position.y] == null)
            {
                grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = null;
                Vector3 newVector = new Vector3(playerObject.transform.position.x-1, playerObject.transform.position.y , playerObject.transform.position.z);
                playerObject.transform.position = newVector;
                grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (playerObject.transform.position.x != grid.GetLength(0)-1 && grid[(int)playerObject.transform.position.x+1, (int)playerObject.transform.position.y] == null)
            {
                grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = null;
                Vector3 newVector = new Vector3(playerObject.transform.position.x+1, playerObject.transform.position.y, playerObject.transform.position.z);
                playerObject.transform.position = newVector;
                grid[(int)playerObject.transform.position.x, (int)playerObject.transform.position.y] = playerObject;
            }
        }
    }
}
