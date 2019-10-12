using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    private Tile[,] grid = new Tile[20,9];
    public Tile[,] Grid { get { return grid; } }
    
    //  TEMP
    public double width = 20;
    public double height = 9;
    public float x,y = 0;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    /// <summary>
    /// Attempts to add a given tile to the grid's coordinates
    /// </summary>
    /// <param name="x">The T's approximate X position in the grid</param>
    /// <param name="y">The T's approximate Y position in the grid</param>
    /// <param name="T">A reference to the object's Tile script</param>
    /// <returns></returns>
    public bool AddToGrid(double x, double y, Tile T) {
        if(grid[(int)x,(int)y] != null) {
            grid[(int)x,(int)y] = T;
            return true;
        }
        return false;
    }
}
