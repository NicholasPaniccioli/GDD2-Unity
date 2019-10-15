using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    private double gridX, gridY;
    private GameObject gridMan = GameObject.Find("GridManager");
    
    // Start is called before the first frame update
    void Start() {
        FindSelfInGrid();
    }

    // Update is called once per frame
    void Update() {
        
    }

    /// <summary>
    /// Adds the object itself to the grid if there is space
    /// </summary>
    private void FindSelfInGrid() {
        if (gridMan.GetComponent<GridManager>().AddToGrid((int)Math.Ceiling(gameObject.transform.position.x), (int)Math.Ceiling(gameObject.transform.position.y), this)) {
            gridX = Math.Ceiling(gameObject.transform.position.x);
            gridY = Math.Ceiling(gameObject.transform.position.y);
        } else {
            Console.WriteLine("Failed to add to grid!");
        }
    }
}
