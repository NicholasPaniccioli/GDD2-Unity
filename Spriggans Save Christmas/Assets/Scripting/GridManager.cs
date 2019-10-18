using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    private Tile[,] grid;
    public Tile[,] Grid { get { return grid; } }

    [SerializeField]
    private int width = 22;
    [SerializeField]
    private int height = 10;
    
    // Start is called before the first frame update
    void Start() {
        grid = new Tile[width, height];
    }

    // Update is called once per frame
    void Update() {
        
    }

    // Add a tile to the grid check if it is already there
    public bool AddToGrid(int x, int y, Tile inputTile) {
        if(x >= 0 && x < width && y >= 0 && y < height && grid[x, y] != inputTile && grid[x,y] == null) {
            grid[x, y] = inputTile;
            Debug.Log("Added a new Tile to " + x + ", " + y + "!");
            return true;
        } else {
            Debug.Log("Failed to add to grid, object at " + x + "," + y + " was not added.");
            return false;
        }
    }
}
