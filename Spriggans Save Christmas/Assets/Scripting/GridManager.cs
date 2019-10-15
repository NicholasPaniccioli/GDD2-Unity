using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    private Tile[,] grid = new Tile[21,9];
    public Tile[,] Grid { get { return grid; } }

    public int width = 21;
    public int height = 9;

    public int x,y = 0;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    // Add a tile to the grid check if it is already there
    public bool AddToGrid(int x, int y, Tile inputTile)
    {
        if(grid[x, y] != inputTile)
        {
            grid[x, y] = inputTile;
            return true;
        }
        else
        {
            return false;
        }
    }
}
