using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    private double gridX, gridY;
    private GridManager gridScript;
    // name of what the tile is i.e. workbench, wood, coal, cloth weaver
    public string name;
    
    // Start is called before the first frame update
    void Start() {
        gridScript = GameObject.Find("GridManager").GetComponent<GridManager>();
        FindSelfInGrid();
    }

    // Update is called once per frame
    void Update() {
        CheckSpaceInGrid();
    }

    /// <summary>
    /// Adds the object itself to the grid if there is space
    /// </summary>
    private void FindSelfInGrid() {
        if (gridScript.AddToGrid((int)Math.Ceiling(transform.position.x), (int)Math.Ceiling(transform.position.y), this)) {
            gridX = Math.Ceiling(transform.position.x);
            gridY = Math.Ceiling(transform.position.y);
        } else {
            Console.WriteLine("Failed to add to grid!");
        }
    }

    private void CheckSpaceInGrid() {
        //  Check new position in grid
    }
}
